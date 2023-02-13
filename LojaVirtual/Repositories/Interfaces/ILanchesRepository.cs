using LojaVirtual.Models;

namespace LojaVirtual.Repositories.Interfaces
{
    public interface ILanchesRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchePreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
