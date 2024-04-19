var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Hello World from Backend #1!");
});

app.Run();
