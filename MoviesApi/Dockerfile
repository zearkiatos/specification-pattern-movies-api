FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source
COPY *.sln .
COPY MoviesApi/*.csproj ./MoviesApi/
COPY MoviesApi/. ./MoviesApi/
COPY MoviesApi.Tests/*.csproj ./MoviesApi.Tests/
COPY MoviesApi.Tests/. ./MoviesApi.Tests/
RUN dotnet sln remove ./MoviesApi.Tests/*.csproj
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "MoviesApi.dll",  "--urls", "http://*:80"]