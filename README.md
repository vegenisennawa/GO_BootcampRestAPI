## REST API for GO BootCAMP.
***Last update:* 2021-08-27**

GO_BootcampRestAPI is a C# API solution using .NET 5 created as a practice.

This project was created in Visual Studio for Mac.
### Project objective

- Create an API that displays a "Hello world" message (*api/HelloWorld/*) in JSON format.

```{
  "helloWorldMessage": "string"
}```

- Create an API that consumes an external API (*api/GetCatFact/*).

```{
  "errorMessage": "string",
  "fact": "string"
}```

#### api/GetCatFact/

This route was used to consume catfact.ninja/fact method, which returns a JSON with a random cat fact and the length of this fact.

GetCatFact consumes this method, and checks if the fact length is lower or equal to 100. If the length is bigger, then this method returns an error message.

### How to test this project

1. Open the solution (sln extension).
2. Choose a web explorer.
3. Execute the solution in Debug mode. This will show a *Swagger* page.
4. Click on any get methods.
5. Click on the *Try it out* button to watch the response.

***Additional***: You can try the API on Postman while the project is running.
### Used references:
- https://apipheny.io/free-api/#apis-without-key
- https://catfact.ninja/
- https://www.luisllamas.es/como-consumir-un-api-rest-como-clientes-con-c/
- https://stackoverflow.com/questions/12775590/routing-with-multiple-get-methods-in-asp-net-web-api
