namespace Distributor.Core.Interfaces.Repositories
{
    public interface IRepartoRepository
    {
        Task<Reparto> GetRepartoByIdAsync(int repartoId);
        Task<IReadOnlyList<Reparto>> GetRepartosAsync();
        Task<Reparto> CreateRepartoAsync(Reparto reparto);
        Task<Reparto> UpdateRepartoAsync(Reparto reparto);
        Task<Reparto> DeleteRepartoAsync(int id);
    }
}
