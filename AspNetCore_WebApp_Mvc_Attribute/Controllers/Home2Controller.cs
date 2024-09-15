using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_WebApp_Mvc_Attribute.Controllers
{
    [Route("Home2")]
    public class Home2Controller : Controller
    {
        [Route("")]
        //[Route("/")]
        [Route("Index")]
        public string Index()
        {
            return "Index() Action Method of Home2Controller";
        }
        [Route("Details/{id?}")]
        public string Details(int id)
        {
            return "Details() Action Method of Home2Controller, ID Value = " + id;
        }

        // Route này sẽ ko tồn tại
        [Route("~/About")]
        // hoặc [Route("/About")]
        public string About(int id)
        {
            return "About() Action Method of Home2Controller";
        }
    }
}


/*
/home2
/home2/index
/home2/details
/home2/details/10
But
http://localhost:xxxx sẽ bị 404
cach khắc phục sử dụng [Route("/")]
để test nhớ bỏ route "" bên Home
 */
