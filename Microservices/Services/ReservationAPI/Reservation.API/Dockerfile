#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Services/ReservationAPI/Reservation.API/Reservation.API.csproj", "Services/ReservationAPI/Reservation.API/"]
COPY ["Services/ReservationAPI/Reservation.API.Infrasturcture/Reservation.API.Infrasturcture.csproj", "Services/ReservationAPI/Reservation.API.Infrasturcture/"]
COPY ["Services/ReservationAPI/Reservation.API.Models/Reservation.API.Models.csproj", "Services/ReservationAPI/Reservation.API.Models/"]
COPY ["Services/ReservationAPI/Reservation.API.Services/Reservation.API.Services.csproj", "Services/ReservationAPI/Reservation.API.Services/"]
RUN dotnet restore "Services/ReservationAPI/Reservation.API/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Services/ReservationAPI/Reservation.API"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]