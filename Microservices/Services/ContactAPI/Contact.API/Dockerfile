#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Services/ContactAPI/Contact.API/Contact.API.csproj", "Services/ContactAPI/Contact.API/"]
COPY ["Services/ContactAPI/Contact.API.Infrasturcture/Contact.API.Infrasturcture.csproj", "Services/ContactAPI/Contact.API.Infrasturcture/"]
COPY ["Services/ContactAPI/Contact.API.Models/Contact.API.Models.csproj", "Services/ContactAPI/Contact.API.Models/"]
COPY ["Services/ContactAPI/Contact.API.Services/Contact.API.Services.csproj", "Services/ContactAPI/Contact.API.Services/"]
RUN dotnet restore "Services/ContactAPI/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/ContactAPI/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]