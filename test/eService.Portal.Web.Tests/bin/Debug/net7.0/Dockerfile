FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/eService.Portal.Web.Mvc/eService.Portal.Web.Mvc.csproj", "src/eService.Portal.Web.Mvc/"]
COPY ["src/eService.Portal.Web.Core/eService.Portal.Web.Core.csproj", "src/eService.Portal.Web.Core/"]
COPY ["src/eService.Portal.Application/eService.Portal.Application.csproj", "src/eService.Portal.Application/"]
COPY ["src/eService.Portal.Core/eService.Portal.Core.csproj", "src/eService.Portal.Core/"]
COPY ["src/eService.Portal.EntityFrameworkCore/eService.Portal.EntityFrameworkCore.csproj", "src/eService.Portal.EntityFrameworkCore/"]
WORKDIR "/src/src/eService.Portal.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/eService.Portal.Web.Mvc", "src/eService.Portal.Web.Mvc"]
COPY ["src/eService.Portal.Web.Core", "src/eService.Portal.Web.Core"]
COPY ["src/eService.Portal.Application", "src/eService.Portal.Application"]
COPY ["src/eService.Portal.Core", "src/eService.Portal.Core"]
COPY ["src/eService.Portal.EntityFrameworkCore", "src/eService.Portal.EntityFrameworkCore"]
WORKDIR "/src/src/eService.Portal.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "eService.Portal.Web.Mvc.dll"]
