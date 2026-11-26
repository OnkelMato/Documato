FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /source

COPY src/Documato.Domain/Documato.Domain.csproj src/Documato.Domain/
COPY src/Documato.Application/Documato.Application.csproj src/Documato.Application/
COPY src/Documato.Infrastructure/Documato.Infrastructure.csproj src/Documato.Infrastructure/
COPY src/Documato.Web/Documato.Web.csproj src/Documato.Web/
RUN dotnet restore src/Documato.Web/Documato.Web.csproj

COPY src/ src/
RUN dotnet publish src/Documato.Web/Documato.Web.csproj \
    --configuration Release --no-restore --output /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
COPY --from=build /app/publish .
USER $APP_UID
ENTRYPOINT ["dotnet", "Documato.Web.dll"]
