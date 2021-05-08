#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging

FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["SGRE.TSA.DataStore.API/SGRE.TSA.DataStore.API.csproj", "SGRE.TSA.DataStore.API/"]
RUN dotnet restore "SGRE.TSA.DataStore.API/SGRE.TSA.DataStore.API.csproj"
COPY . .
WORKDIR "/src/SGRE.TSA.DataStore.API"
RUN dotnet build "SGRE.TSA.DataStore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SGRE.TSA.DataStore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SGRE.TSA.DataStore.API.dll"]