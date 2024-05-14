using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using System.Threading.Tasks;
using System.Globalization;
using MvcApplication1.DAL;
using System.Diagnostics;


namespace MvcApplication1.Controllers
{
    public class MembershipController : Controller
    {
        //
        // GET: /Membership/
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {

                using (var db = new UserDBContext())
                {

                    try
                    {
                        // 사용자 등록 메서드 호출
                        db.UserRegister(user);


                        // 회원가입 성공
                        return RedirectToAction("Login", "Membership");
                    }
                    catch (Exception ex)
                    {
                        //회원가입 실패

                        Debug.WriteLine(ex.ToString());
                        return RedirectToAction("Register", "Membership");
                    }
                }
          
        }
    }
}
