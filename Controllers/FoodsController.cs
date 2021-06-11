using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers     //be sure to use your own project's namespace!
{
    public class FoodsController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]       //type of request
        [Route("projects")]     //associated route string (exclude the leading /)
        public string Projects()
        {
            return "These are my projects!";
        }

        [HttpGet]       //type of request
        [Route("contact")]     //associated route string (exclude the leading /)
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}