FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app
COPY . .
RUN dotnet restore './FinanceManager.Api/FinanceManager.Api.csproj' --disable-parallel
RUN dotnet publish './FinanceManager.Api/FinanceManager.Api.csproj' -c Release -o dist --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=base /app/dist ./

EXPOSE 5000

ENTRYPOINT [ "dotnet", "FinanceManager.Api.dll" ]