using AMST4.carousel.mvc.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMST4.carousel.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDataContext _applicationDataContext;
        public CategoryController(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }
        public IActionResult CategoryList()
        {
            var categories = _applicationDataContext.Category.ToList();

            return View(categories);
        }
    }
}