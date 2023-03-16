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
            //ViewData["Titulo"] = "Todos os Lanches";
            //ViewData["Data"] = DateTime.Now;

            
            var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();

            //ViewBag.Total = "Total de Lanches: ";
            //ViewBag.TotalLanches = totalLanches;

            return View(lanches);
        }
    }
}
