FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-ltsc2022 AS build
WORKDIR /CG


COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-ltsc2022
WORKDIR /CG
COPY --from=build /CG/out .
ENTRYPOINT ["dotnet", "CG.dll"]
