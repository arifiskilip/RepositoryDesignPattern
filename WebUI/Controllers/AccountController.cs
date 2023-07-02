using Microsoft.AspNetCore.Mvc;
using WebUI.Core.Mappings.AccountMapping;
using WebUI.Core.Mappings.UserMapping;
using WebUI.Core.Repositories.Abstract;
using WebUI.Core.UnitOfWork;
using WebUI.Entities.Models;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
       private readonly IUserService _userService;
        private readonly IUserMap _userMap;
        private readonly IUoW _uoW;
        private readonly IAccountService _accountService;
        private readonly IAccountMapping _accountMapping;

        public AccountController(IUserService userService, IUserMap userMap, IUoW uoW, IAccountService accountService, IAccountMapping accountMapping)
        {
            _userService = userService;
            _userMap = userMap;
            _uoW = uoW;
            _accountService = accountService;
            _accountMapping = accountMapping;
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.userId = id;
            var user = _userMap.UserToUserModel(_userService.GetById(id));  

            UserAcountCreateRelation model = new UserAcountCreateRelation
            {
                UserModel = user,
                CreateAccountModel = new CreateAccountModel(),
            };

         
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateAccountModel createAccountModel)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(_accountMapping.CreateAccountModelToAccount(createAccountModel));
                _uoW.Commit();
                return RedirectToAction("Index", "Home");
            }
            return View(createAccountModel);
        }
    }


}
