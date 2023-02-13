using LojaVirtual.Models;

namespace LojaVirtual.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria>Categorias { get; }
    }
}
