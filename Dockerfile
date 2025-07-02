FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /CG

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c release -o /CG

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /CG
COPY --from=build /CG ./

EXPOSE 8080

ENTRYPOINT ["dotnet", "CG.dll"]