FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /chess-good/CG

COPY *.csproj ./chess-good/CG
RUN dotnet restore

COPY . ./CG
RUN dotnet publish -c release -o /chess-good/CG

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /chess-good/CG
COPY --from=build /chess-good/CG ./chess-good/CG

EXPOSE 8080

ENTRYPOINT ["dotnet", "CG.dll"]