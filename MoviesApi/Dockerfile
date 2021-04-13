FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app


COPY *.csproj ./

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

# ENTRYPOINT [ "tail", "-f", "/dev/null" ]


FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "run"]

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