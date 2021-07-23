#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Turma3API/Turma3API.csproj", "Turma3API/"]
RUN dotnet restore "Turma3API/Turma3API.csproj"
COPY . .
WORKDIR "/src/Turma3API"
RUN dotnet build "Turma3API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Turma3API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Turma3API.dll"]