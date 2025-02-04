using DataAccess;
using DataAccess.Models;
using DataAccess.SqlServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsService.ViewModel;

namespace ProductsService.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices )
        {
            _productServices = productServices;
        }
        [HttpGet]
        public async Task<IActionResult> Getproduct(int PageSize, int Pagenum) { 
        return Ok(await _productServices.GetAllProductpages(PageSize, Pagenum));
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductVM addProductVM)
        {
            if (addProductVM == null)
            {
                return Ok(new { V = 0 });
            }
            else
            {
                ProductModel model = new ProductModel();
                model.ProductName = addProductVM.ProductName;
                model.Category = addProductVM.Category;
                return Ok(await _productServices.InsertProduct(model));
            }
        }
    }
}
