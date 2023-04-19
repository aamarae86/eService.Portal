FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/eService.Portal.Web.Host/eService.Portal.Web.Host.csproj", "src/eService.Portal.Web.Host/"]
COPY ["src/eService.Portal.Web.Core/eService.Portal.Web.Core.csproj", "src/eService.Portal.Web.Core/"]
COPY ["src/eService.Portal.Application/eService.Portal.Application.csproj", "src/eService.Portal.Application/"]
COPY ["src/eService.Portal.Core/eService.Portal.Core.csproj", "src/eService.Portal.Core/"]
COPY ["src/eService.Portal.EntityFrameworkCore/eService.Portal.EntityFrameworkCore.csproj", "src/eService.Portal.EntityFrameworkCore/"]
WORKDIR "/src/src/eService.Portal.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/eService.Portal.Web.Host", "src/eService.Portal.Web.Host"]
COPY ["src/eService.Portal.Web.Core", "src/eService.Portal.Web.Core"]
COPY ["src/eService.Portal.Application", "src/eService.Portal.Application"]
COPY ["src/eService.Portal.Core", "src/eService.Portal.Core"]
COPY ["src/eService.Portal.EntityFrameworkCore", "src/eService.Portal.EntityFrameworkCore"]
WORKDIR "/src/src/eService.Portal.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "eService.Portal.Web.Host.dll"]
