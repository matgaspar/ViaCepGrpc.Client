using Microsoft.Extensions.DependencyInjection;
using ViaCepGrpc.Services;
using ViaCepGrpc.Services.Services;
using ViaCepGrpc.Services.Services.Interfaces;

namespace ViaCepGrpc.IoC;
public class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddGrpcClient<ViaCep.ViaCepClient>(o =>
        {
            o.Address = new Uri("https://localhost:8001");
        });
        services.AddScoped<IViaCepService, ViaCepService>();
    }

}
