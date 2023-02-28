using LojaVirtual.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class LancheController : Controller
    {
        // para acessar os dados do banco de dados utilizando injeção de dependência
        private readonly ILanchesRepository _lancheRepository;


        // instância do repositório injetada
        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }


        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
