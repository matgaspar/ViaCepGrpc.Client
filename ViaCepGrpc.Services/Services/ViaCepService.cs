using ViaCepGrpc.Services.Services.Interfaces;
using ViaCepGrpc.Services;

namespace ViaCepGrpc.Services.Services;

public class ViaCepService : IViaCepService
{
    private readonly ViaCep.ViaCepClient _client;

    public ViaCepService(ViaCep.ViaCepClient client)
    {
        _client = client;
    }

    public async Task<ViaCepResponse> GetAddressByCepAsync(string cep)
    {
        return await _client.GetAddressByCepAsync(new()
        {
            Cep = cep
        });
    }
}