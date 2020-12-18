FROM mcr.microsoft.com/dotnet/sdk:3.1 AS builder

COPY . /
RUN cd /src && \
    mkdir -p /.output && \
    dotnet publish *.csproj --configuration Release --output /.output

FROM mcr.microsoft.com/azure-functions/dotnet:3.0
ENV AzureWebJobsScriptRoot=/home/site/wwwroot

COPY --from=builder ["/.output", "/home/site/wwwroot"]
