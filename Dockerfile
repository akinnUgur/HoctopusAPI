#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["./HotelBookAPI/Presentation/HotelBookAPI.API/HotelBookAPI.API.csproj", "./HotelBookAPI/Presentation/HotelBookAPI.API/"]
COPY ["./HotelBookAPI/Application/HotelBookAPI.Application/HotelBookAPI.Application.csproj", "./HotelBookAPI/Application/HotelBookAPI.Application/"]
COPY ["./HotelBookAPI/Infrastructure/HotelBookAPI.Infrastructure/HotelBookAPI.Infrastructure.csproj", "./HotelBookAPI/Infrastructure/HotelBookAPI.Infrastructure/"]
RUN dotnet restore "./HotelBookAPI/Presentation/HotelBookAPI.API/HotelBookAPI.API.csproj"
COPY . .
WORKDIR "./HotelBookAPI/Presentation/HotelBookAPI.API"
RUN dotnet build "./HotelBookAPI/Presentation/HotelBookAPI.API/HotelBookAPI.API.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HotelBookAPI.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotelBookAPI.API.dll"]