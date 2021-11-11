using Microsoft.AspNetCore.Mvc;
using WS_Lanches.Repositories;
using WS_Lanches.ViewModels;

namespace WS_Lanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository) {
            _lancheRepository = lancheRepository;    
        }

        public IActionResult Index() {
            var homeViewModel = new HomeViewModel {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }     
    }
}
