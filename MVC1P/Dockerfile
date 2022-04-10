FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MVC1P/MVC1P.csproj", "MVC1P/"]
RUN dotnet restore "MVC1P/MVC1P.csproj"
COPY . .
WORKDIR "/src/MVC1P"
RUN dotnet build "MVC1P.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVC1P.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVC1P.dll"]