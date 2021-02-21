using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data.ViewModels;
using NetCore.Services.Interface;
using NetCore.Services.Svcs;
using NetCore.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore.Web.Controllers
{
    public class MembershipController : Controller
    {
        //private IUser _user = new UserService(); 의존성 주입이 아님
        //의존성 주입 - 생성자

        private IUser _user;

        public MembershipController(IUser user)
        {
            _user = user;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Data -> Service -> Web
        //Data -> Services
        //Data -> Web
        public ActionResult Login(LoginInfo login)
        {
            string message = String.Empty;
            if(ModelState.IsValid)
            {
                //뷰모델
                //서비스 개/
                //string userId = "dodaam";
                //string password = "123456";

               // if (login.UserId.Equals(userId) && login.Password.Equals(password))
               if(_user.MatchTheUserInfo(login))

                {
                    TempData["Message"] = "로그인이 성공적으로 이루어졌습니다.";
                    return RedirectToAction("Index", "Membership");
                }
                else
                {
                    message = "로그인되지 않았습니다.";
                }
            }
            else
            {
                message = "로그인정보를 올바르게 입력하세요.";
            }
            ModelState.AddModelError(String.Empty, message);
            return View(login);

        }
        
    }
}
