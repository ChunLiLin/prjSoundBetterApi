using Microsoft.AspNetCore.Mvc;

namespace prjSoundBetterApi.Controllers
{
    public class VCProjectController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
		public IActionResult Create()
		{
			return View();
		}
	}
}
