FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /CG

COPY CG/CG.csproj CG/
RUN dotnet restore

COPY . ./
RUN dotnet publish -c release -o out CG/CG.csproj

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /CG
COPY --from=build /CG ./

EXPOSE 8080

ENTRYPOINT ["dotnet", "CG.dll"]