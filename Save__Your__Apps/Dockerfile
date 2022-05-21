#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Save__Your__Apps/Save__Your__Apps.csproj", "Save__Your__Apps/"]
RUN dotnet restore "Save__Your__Apps/Save__Your__Apps.csproj"
COPY . .
WORKDIR "/src/Save__Your__Apps"
RUN dotnet build "Save__Your__Apps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Save__Your__Apps.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Save__Your__Apps.dll"]