using Microsoft.AspNetCore.Mvc;
using MvcNetCoreChollometro.Models;
using MvcNetCoreChollometro.Repositories;

namespace MvcNetCoreChollometro.Controllers
{
    public class ChollosController : Controller
    {
        private RepositoryChollometro repo;
        public ChollosController(RepositoryChollometro repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            List<Chollo> chollos = await this.repo.GetChollosAsync();
            ViewData["ELEMENTOS"] = chollos.Count;
            return View(chollos);
        }
    }
}
