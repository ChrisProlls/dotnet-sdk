# Need to launch docker build from the repo root
# docker build -f .\examples\Actor\DemoActor\Dockerfile .

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY examples/Actor/DemoActor ./examples/Actor/DemoActor
COPY examples/Actor/IDemoActor ./examples/Actor/IDemoActor
RUN dotnet restore examples/Actor/DemoActor

# Copy everything else and build
COPY . .
RUN dotnet publish examples/Actor/DemoActor -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DemoActor.dll"]