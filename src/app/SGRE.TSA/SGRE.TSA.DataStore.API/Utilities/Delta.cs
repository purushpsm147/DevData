using FastMember;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;


namespace SGRE.TSA.DataStore.API.Utilities
{
	/// Credit: This delta class was taken and adapted from: https://gist.github.com/anonymous/34c976cb816b6caaa520.
	//[JsonConverter(typeof(DeltaSerializer))]
	public class Delta<T> : DynamicObject where T : class
	{
		private HashSet<string> _changedMembers;
		private T _entity;
		private Type _entityType;
		private TypeAccessor _accessor;


		public Delta() : this(typeof(T))
		{

		}


		public Delta(Type entityType)
		{
			Initialize(entityType);
		}


		public Type EntityType
		{
			get
			{
				return _entityType;
			}
		}


		public void Clear()
		{
			Initialize(_entityType);
		}

		public bool TrySetPropertyValue(string name, object value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			if (value is Int64)
			{
				long actual = (Int64)value;

				if (actual <= Int32.MaxValue && actual >= Int32.MinValue)
				{
					_accessor[_entity, name] = Convert.ToInt32(value);
				}
			}
			else if (value is Double && _accessor.GetMembers().Where(
				m => m.Name == name
				&& (
					m.Type == typeof(decimal)
					|| (
						m.Type.IsGenericType
						&& m.Type.GetGenericTypeDefinition() == typeof(Nullable<>)
						&& m.Type.GetGenericArguments()[0] == typeof(decimal)
					)
				)).Count() == 1)
			{
				_accessor[_entity, name] = Convert.ToDecimal(value);
			}
			else if (value is string && _accessor.GetMembers().Where(
				m => m.Name == name
				&& (
					m.Type == typeof(TimeSpan)
					|| (
						m.Type.IsGenericType
						&& m.Type.GetGenericTypeDefinition() == typeof(Nullable<>)
						&& m.Type.GetGenericArguments()[0] == typeof(TimeSpan)
					)
				)).Count() == 1)
			{

				_accessor[_entity, name] = value != null ? TimeSpan.Parse((string)value) : (TimeSpan?)null;
			}
			else
			{
				try
				{
					_accessor[_entity, name] = value;
				}
				catch (Exception ex)
				{
					//ToDo log this error
					Exception thrown = ex;
				}
			}

			_changedMembers.Add(name);
			return true;
		}


		public bool TryGetPropertyValue(string name, out object value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			try
			{
				value = _accessor[_entity, name];
				return true;
			}
			catch (Exception)
			{
				value = null;
				return false;
			}
		}


		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			if (binder == null)
			{
				throw new ArgumentNullException("binder");
			}

			return TrySetPropertyValue(binder.Name, value);
		}


		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			if (binder == null)
			{
				throw new ArgumentNullException("binder");
			}

			return TryGetPropertyValue(binder.Name, out result);
		}


		public IEnumerable<string> GetChangedMemberNames()
		{
			return _changedMembers;
		}


		public IEnumerable<string> GetUnchangedMemberNames()
		{
			return _accessor.GetMembers().Select(p => p.Name).Except(GetChangedMemberNames());
		}

		public void CopyChangedValues(T original)
		{
			T from = _entity;
			T to = original;

			foreach (string property in GetChangedMemberNames())
			{
				_accessor[to, property] = _accessor[from, property];
			}
		}

		public void CopyUnchangedValues(T original)
		{
			T from = _entity;
			T to = original;

			foreach (string property in GetUnchangedMemberNames())
			{
				_accessor[to, property] = _accessor[from, property];
			}
		}

		public void Patch(T original)
		{
			CopyChangedValues(original);
		}

		public void Put(T original)
		{
			CopyChangedValues(original);
			CopyUnchangedValues(original);
		}

		private void Initialize(Type entityType)
		{
			_accessor = TypeAccessor.Create(entityType);
			_entity = Activator.CreateInstance(entityType) as T;
			_changedMembers = new HashSet<string>();
			_entityType = entityType;
		}

		public T GetEntity()
		{
			return _entity;
		}

		public IDictionary<string, object> ToHash()
		{
			return GetChangedMemberNames().ToDictionary(member => member, member => _accessor[_entity, member]);
		}

		public void LoadFrom(object source, object original)
		{

			List<PropertyInfo> properties = original.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

			foreach (PropertyInfo info in source.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				PropertyInfo match = properties.Where(
					p => p.Name == info.Name
					&& (
						p.PropertyType == info.PropertyType
						|| (
							p.PropertyType.IsGenericType
							&& p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)
							&& p.PropertyType.GetGenericArguments()[0] == info.PropertyType
						)
					)).FirstOrDefault();

				if (match != null && match.GetValue(original) != info.GetValue(source) && info.GetValue(source) != null)
				{
					this.TrySetPropertyValue(info.Name, info.GetValue(source));
				}
			}
		}
	}
}


