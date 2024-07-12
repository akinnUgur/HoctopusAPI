# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY HotelbookAPI.Api/*.csproj ./ HotelbookAPI.Api/
COPY  HotelbookAPI.Application/*.csproj ./ HotelbookAPI.Allpication/
COPY  HotelbookAPI.Infrastructure/*.csproj ./ HotelbookAPI.Infrastructure/
RUN dotnet restore

# Copy everything else and build
COPY . .
WORKDIR /source/[YourProjectName].Api
RUN dotnet publish -c Release -o /app

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "HotelbookAPI.Api.dll"]