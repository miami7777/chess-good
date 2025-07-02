FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY CG/CG.csproj ./
RUN dotnet restore ./CG.csproj

COPY CG ./
RUN dotnet publish ./CG.csproj -c release -o /publish 

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /publish ./

EXPOSE 80 5195 7066
ENV ASPNETCORE_URLS=http://chess-good.ru;https://chess-good.ru

ENTRYPOINT ["dotnet", "CG.dll"]