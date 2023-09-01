Elevator Control System API

Elevator Control System API
===========================

Instructions to Run the Project
-------------------------------

1.  Make sure you have the latest version of [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) installed.
2.  Clone this repository to your local machine.
3.  Navigate to the project directory in the terminal.
4.  Run the following command to build and run the project:

```dotnet run ```

Available Endpoints
-------------------

The API provides the following endpoints:

* **POST /elevator/request**: Send an elevator to a requested floor.
* **POST /elevator/destination**: Set a passenger's desired destination floor.
* **GET /elevator/passenger-floors**: Get the list of passenger-requested floors.
* **GET /elevator/next-floor**: Get the next floor the elevator needs to service.

Testing the API
---------------

You can use tools like [Postman](https://www.postman.com/) or [cURL](https://curl.se/) to test the API:

* Open Postman or the terminal.
* Make requests to the specified endpoints using the appropriate HTTP methods and request payloads.
* Inspect the responses to verify the behavior of the elevator control system.

Example cURL command:

```curl -X POST -H "Content-Type: application/json" -d "3" http://localhost:7074/elevator/request ```

Further Improvements
--------------------

This is a basic example of an elevator control system API. We can enhance the project by adding more advanced elevator scheduling algorithms and error handling.
