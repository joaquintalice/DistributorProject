using Distributor.Core.DTOs.Reparto;

namespace Distributor.Core.Interfaces.Services
{
    public interface IRepartoService
    {
        Task<List<RepartoDTO>> GetAllRepartosAsync();
        Task<RepartoDTO> GetRepartoByIdAsync(int id);
        Task<RepartoDTO> CreateRepartoAsync(CreateRepartoDTO repartoDTO);
        Task<RepartoDTO> UpdateRepartoAsync(int id, CreateRepartoDTO repartoDTO);
        Task DeleteRepartoAsync(int id);
    }
}
