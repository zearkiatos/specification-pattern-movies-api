FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source
COPY *.sln .
COPY MoviesApi/*.csproj ./MoviesApi/
RUN dotnet restore
WORKDIR /source/MoviesApi
RUN dotnet publish -c release -o /app --no-restore
ENTRYPOINT [ "tail", "-f", "/dev/null" ]

# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# COPY --from=build /app .
# ENTRYPOINT ["dotnet", "MoviesApi.dll"]
# # final stage/image
# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# COPY --from=build /app ./
# ENTRYPOINT ["dotnet", "MoviesApi.dll"]
# FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
# WORKDIR /app


# COPY *.csproj ./

# COPY . ./

# RUN dotnet restore
# RUN dotnet publish -c Release -o out


# FROM mcr.microsoft.com/dotnet/aspnet:5.0
# WORKDIR /app
# COPY --from=build-env /app/out .
# RUN apt-get update && \
#     apt-get upgrade -y && \
#     apt-get install -y nodejs && \
#     yes | apt-get install wget && \
#     yes | wget -q https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
#     dpkg -i packages-microsoft-prod.deb && \
#     apt-get update && apt-get upgrade -y && \
#     apt-get install apt-transport-https && \
#     apt-get update && \
#     yes | apt-get install dotnet-sdk-5.0
# ENTRYPOINT [ "tail", "-f", "/dev/null" ]
# ENTRYPOINT ["dotnet", "MoviesApi.dll"]

# FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build 

# WORKDIR /app

# RUN apt-get update && \
#     apt-get upgrade -y && \
#     apt-get install -y nodejs && \
#     yes | apt-get install wget && \
#     yes | wget -q https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
#     dpkg -i packages-microsoft-prod.deb && \
#     apt-get update && apt-get upgrade -y && \
#     apt-get install apt-transport-https && \
#     apt-get update && \
#     yes | apt-get install dotnet-sdk-5.0
    

# COPY . .

# RUN rm -r MoviesApi/bin && \
#     rm -r MoviesApi/obj

# RUN dotnet clean && \
# dotnet restore && \
# dotnet publish -c Release -o out && \
# dotnet build

# EXPOSE 5000

# ENTRYPOINT ["dotnet", "run", "-p", "MoviesApi", "--no-restore", "--urls", "http://*:5000"]


# FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
# WORKDIR /app


# COPY *.csproj ./
# RUN dotnet restore


# COPY . ./
# RUN dotnet publish -c Release -o out


# FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "aspnetapp.dll"]