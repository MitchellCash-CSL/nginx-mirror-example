var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Hello World from Backend #2!");
});

app.Run();
