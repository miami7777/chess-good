FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /CG

COPY *.csproj ./CG
RUN dotnet restore

COPY . ./CG
RUN dotnet publish -c release -o /CG

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /CG
COPY --from=build /CG ./CG

EXPOSE 8080

ENTRYPOINT ["dotnet", "CG.dll"]