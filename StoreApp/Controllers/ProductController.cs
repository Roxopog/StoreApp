using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller

    {

        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager; 
        }


        public IActionResult Index()
        {   
            var model = _manager.ProdcutService.GetAllProducts(false);
            return View(model);

        }

        public IActionResult Get(int id)
        {
            var model = _manager.ProdcutService.GetOneProduct(id, false);
            return View(model);
            
        }

    }
}