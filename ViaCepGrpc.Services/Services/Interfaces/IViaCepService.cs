using ViaCepGrpc.Services;

namespace ViaCepGrpc.Services.Services.Interfaces
{
    public interface IViaCepService
    {
        Task<ViaCepResponse> GetAddressByCepAsync(string cep);
    }
}