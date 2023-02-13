using LojaVirtual.Context;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Interfaces;

namespace LojaVirtual.Repositories
{
    public class CategoriaRespository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRespository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
