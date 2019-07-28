FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Register.Api/Register.Api.csproj", "Register.Api/"]
RUN dotnet restore "Register.Api/Register.Api.csproj"
COPY . .
WORKDIR "/src/Register.Api"
RUN dotnet build "Register.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Register.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Register.Api.dll"]