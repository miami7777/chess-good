FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY CG/CG.csproj ./
RUN dotnet restore ./CG.csproj

COPY CG ./
RUN dotnet publish ./CG.csproj -c release -o /publish 

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /CG
COPY --from=build /CG ./

EXPOSE 8080

ENTRYPOINT ["dotnet", "CG.dll"]