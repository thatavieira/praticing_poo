FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SchoolExercise/SchoolExercise.csproj", "SchoolExercise/"]
RUN dotnet restore "SchoolExercise/SchoolExercise.csproj"
COPY . .
WORKDIR "/src/SchoolExercise"
RUN dotnet build "SchoolExercise.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolExercise.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolExercise.dll"]
