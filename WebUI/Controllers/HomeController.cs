using Microsoft.AspNetCore.Mvc;
using WebUI.Core.Mappings.UserMapping;
using WebUI.Core.Repositories.Abstract;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserMap _userMap;

        public HomeController(IUserService userService, IUserMap userMap)
        {
            _userService = userService;
            _userMap = userMap;
        }

        public IActionResult Index()
        {
            var result = _userMap.UserToUserModels(_userService.GetAll());
            return View(result);
        }
    }
}
