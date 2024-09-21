using _5._AspNetCore_WebApp_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5._AspNetCore_WebApp_ViewComponent.ViewComponents
{
    public class TopProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            ProductRepository productRepository = new ProductRepository();
            var products = await productRepository.GetTopProductsAsync(count);
            return View(products);
        }

        //public IViewComponentResult Invoke(int count)
        //{
        // // Your logic for preparing data
        // ProductRepository productRepository = new ProductRepository();
        // var products = productRepository.GetTopProductsAsync(count).Result;
        // return View(products);
        //}
    }
}
