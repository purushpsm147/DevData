using System;

namespace SGRE.TSA.DataStore.API.Models
{
    public abstract class Audit
    {
        public DateTimeOffset? RecordInsertDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    }
}
