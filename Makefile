build:
	dotnet build /p:Platform="Any CPU" /p:Configuration=Debug

build-release:
	dotnet build /p:Platform="Any CPU" /p:Configuration=Release

run:
	dotnet run /p:Platform="Any CPU" /p:Configuration=Debug --project TaskService

build-docker:
	docker build -t csharp-sample .

run-docker:
	docker run -it --rm -p 5000:80 csharp-sample

