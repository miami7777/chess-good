FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /source
COPY *.sln .
COPY CG/*.csproj ./CG/
RUN dotnet restore --disable-parallel

COPY CG/. ./CG/
WORKDIR /source/CG
RUN dotnet publish -c release -o /app --no-restore

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "CG.dll"]
