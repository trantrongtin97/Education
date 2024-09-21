using ViewComponent.Models;

namespace ViewComponent.ViewComponents
{
    public class TopProductViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task<Microsoft.AspNetCore.Mvc.IViewComponentResult> InvokeAsync(int count)
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
