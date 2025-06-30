ARG TAG=ltsc2022
FROM mcr.microsoft.com/dotnet/sdk:9.0-nanoserver-$TAG AS build

WORKDIR /source
COPY *.sln .
COPY CG/*.csproj ./CG/
RUN dotnet restore --disable-parallel

COPY CG/. ./CG/
WORKDIR /source/CG
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/sdk:9.0-nanoserver-$TAG
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "CG.dll"]
