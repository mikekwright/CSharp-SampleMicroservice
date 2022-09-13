FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . /src
RUN dotnet restore
COPY . .
#RUN dotnet build /p:Platform="Any CPU" /p:Configuration=Release -o /app/publish
RUN dotnet publish /p:Platform="Any CPU" /p:Configuration=Release -o /app/publish

#FROM build AS publish
#RUN dotnet publish "TaskService.csproj" -c Release -o /app/publish

#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS final
FROM base AS final
WORKDIR /app
#COPY --from=build /src/TaskService/bin/Release/netcorapp3.1 .
COPY --from=build /app/publish .
ENTRYPOINT ["./TaskService"]
