namespace Distributor.Core.Interfaces.Repositories
{
    public interface IRepartoRepository
    {
        Task<Reparto> GetRepartoByIdAsync(int repartoId);
        Task<List<Reparto>> GetRepartosAsync();
        Task<Reparto> CreateRepartoAsync(Reparto reparto);
        Task<Reparto> UpdateRepartoAsync(int id);
        Task<Reparto> DeleteRepartoAsync(int id);
    }
}
