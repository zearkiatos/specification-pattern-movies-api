FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build 

WORKDIR /app

RUN apt-get update && \
    apt-get upgrade -y && \
    apt-get install -y nodejs && \
    yes | apt-get install wget && \
    yes | wget -q https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    apt-get update && apt-get upgrade -y && \
    apt-get install apt-transport-https && \
    apt-get update && \
    yes | apt-get install dotnet-sdk-5.0
    

COPY . .

RUN dotnet tool install -g dotnet-aspnet-codegenerato && \
dotnet restore && \
dotnet publish -c Release -o out && \
dotnet build

EXPOSE 5000

ENTRYPOINT ["dotnet", "watch", "-p", "MoviesApi", "run", "--no-restore", "--urls", "http://*:5000"]