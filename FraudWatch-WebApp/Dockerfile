FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY FraudWatch-WebApp.sln .
COPY FraudWatch-WebApp/FraudWatch-WebApp.csproj ./FraudWatch-WebApp/
RUN dotnet restore FraudWatch-WebApp.sln

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "FraudWatch-WebApp.dll"]