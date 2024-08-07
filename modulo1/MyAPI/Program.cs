using MyAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Hello World");
});

app.MapGet("/{nome}", (string nome) => {
    return Results.Ok($"Hello {nome}");
});

app.MapPost("/", (User user) => {
    return Results.Ok(user);
} );

app.Run();


