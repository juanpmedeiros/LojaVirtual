using LojaVirtual.Context;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches
                                   .Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchePreferidos => _context.Lanches
                                   .Where(l => l.IsLanchePreferido)
                                   .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
