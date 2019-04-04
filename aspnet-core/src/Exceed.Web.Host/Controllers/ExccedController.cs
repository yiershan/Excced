using Exceed.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Exceed.Web.Host.Controllers
{
    public class ExccedController: ExceedControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
