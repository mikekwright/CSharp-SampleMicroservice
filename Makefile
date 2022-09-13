build:
	dotnet build /p:Platform="Any CPU" /p:Configuration=Debug

build-release:
	dotnet build /p:Platform="Any CPU" /p:Configuration=Release

run:
	dotnet run /p:Platform="Any CPU" /p:Configuration=Debug --project TaskService
