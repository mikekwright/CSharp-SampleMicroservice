C# Sample Microservice
======================================

This repo demonstrates how you can create a rest based microservice in C# with an example of dependency
injection as well as a rest endpoint.

Running (Local)
------------------------------

Start the app by having dotnet core installed.  You can build and run the app by using the following
make commands.

    make build
    make run

You can then test an endpoint by running

    curl http://localhost:5000/user
    # or
    curl -k https://localhost:5001/user

Running (Docker)
-----------------------------------------------------------------

Start the app by running the following:

    make build-docker
    make run-docker

View Swagger
-----------------------------------------------

There exists an automatic swagger generated endpoint that can be
found, once the app is running at

    http://localhost:5000/swagger
