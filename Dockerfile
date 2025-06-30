ARG TAG=ltsc2022
mcr.microsoft.com/dotnet/aspnet:8.0-preview-nanoserver-$TAG AS build

WORKDIR /source
COPY *.sln .
COPY CG/*.csproj ./CG/
RUN dotnet restore --disable-parallel

COPY CG/. ./CG/
WORKDIR /source/CG
RUN dotnet publish -c release -o /app --no-restore

mcr.microsoft.com/dotnet/aspnet:8.0-preview-nanoserver-$TAG
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "CG.dll"]
