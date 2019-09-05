FROM microsoft/dotnet:2.2-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY InformixMainApp/InformixMainApp.csproj InformixMainApp/
RUN dotnet restore InformixMainApp/InformixMainApp.csproj
COPY . .
WORKDIR /src/InformixMainApp
RUN dotnet build InformixMainApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish InformixMainApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "InformixMainApp.dll"]
