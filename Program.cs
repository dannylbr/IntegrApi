var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Elegant.");

app.MapGet("/user/{id}", (string id) =>
{

    var user = new User(id, "Integrae Solutions", "integraesol@gmail.com");
    return user;
});

app.Run();