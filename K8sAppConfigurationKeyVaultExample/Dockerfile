FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src

COPY ./ ./

RUN dotnet publish ./K8sAppConfigurationKeyVaultExample.csproj -o /publish --configuration Release

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base

WORKDIR /app

EXPOSE 80
EXPOSE 443

COPY --from=build /publish .

ENTRYPOINT ["dotnet", "K8sAppConfigurationKeyVaultExample.dll"]
