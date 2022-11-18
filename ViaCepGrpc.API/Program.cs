using ViaCepGrpc.IoC;
using ViaCepGrpc.Services.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
DependencyContainer.RegisterServices(builder.Services);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/Address/{cep}", async (IViaCepService viaCepService, string cep) =>
{
    var data = await viaCepService.GetAddressByCepAsync(cep);

    if (data == null)
        return Results.NotFound();

    return Results.Ok(data);
});

app.Run();
