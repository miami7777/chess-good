FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build-env
WORKDIR /CG

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:8.0-alpine
WORKDIR /CG
COPY --from=build-env /CG/out .
ENTRYPOINT ["dotnet", "CG.dll"]
