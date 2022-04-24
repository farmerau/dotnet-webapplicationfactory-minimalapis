var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Farmer.Codes.MinimalApis.WebApplicationFactoryDemo.Constants.HelloWorldResponse);

app.Run();