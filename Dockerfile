# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /app/src

# Restore
COPY ["src/cbackend/backend.csproj", "backend/"]
WORKDIR /app/src/backend
RUN dotnet restore "backend.csproj"

# Build
# Copy the rest of the application code
COPY ["src/backend/", "./"]
WORKDIR /app/src/backend
RUN dotnet build "backend.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
WORKDIR /app/src/backend
RUN dotnet publish "backend.csproj" -c Release --no-restore -o /app/publish

# Stage 3: Run
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS base
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 8080

ENTRYPOINT [ "dotnet", "backend.dll" ]
