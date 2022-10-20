FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./MinimalAPI.csproj"
RUN dotnet build "./MinimalAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimalAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimalAPI.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MinimalAPI.dll