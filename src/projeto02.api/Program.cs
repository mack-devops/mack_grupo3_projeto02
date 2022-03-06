var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseSwagger();

app.MapGet("/", () => ">>> API Online <<<");

app.MapPost("/Soma", (CalculoVars calc) =>
{
    return $"result = {calc.x + calc.y}";
});

app.MapPost("/Subt", (CalculoVars calc) =>
{
    return $"result = {calc.x - calc.y}";
});

app.MapPost("/Mult", (CalculoVars calc) =>
{
    return $"result = {calc.x * calc.y}";
});

app.UseSwaggerUI();

app.Run();

public record CalculoVars(int x, int y);