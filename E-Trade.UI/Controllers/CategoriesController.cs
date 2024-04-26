using Microsoft.AspNetCore.Mvc;

namespace E_Trade.UI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly HttpClient _httpClient;

        public CategoriesController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public Task<IActionResult> Index()
        //{
        //    return View();
        //}
    }
}
