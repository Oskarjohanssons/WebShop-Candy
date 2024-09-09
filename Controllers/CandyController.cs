using Microsoft.AspNetCore.Mvc;
using WebShop_Candy.Service;
using WebShop_Candy.ViewModels;

namespace WebShop_Candy.Controllers
{
    public class CandyController : Controller
    {

        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }


        public IActionResult List()
        {

            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Best Seller";
            return View(candyListViewModel);
        }
    }
}
