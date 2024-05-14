using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using System.Threading.Tasks;
using System.Globalization;
using MvcApplication1.DAL;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MvcApplication1.Controllers
{
    public class MembershipController : Controller
    {
        //로그인 페이지
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // 회원가입 페이지 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        //투두리스트 페이지 
        [HttpGet]
        public IActionResult TodoList() 
        {
            return View();
        }

        [HttpGet]
        //투두리스트 수정페이
        public IActionResult TodoListUpdate() 
        {

            return View();
        }


        // 회원가입 (아이디 중복체크)
        [HttpPost]
        public string IdCheck(string id)
        {
            using (var db = new UserDBContext())
            {
                try
                {
                    // 사용자 등록 메서드 호출
                    string result = db.UserRegisterIdcheck(id);

                    return result;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                return "E";
            }

        }

        // 회원가입
        [HttpPost]
        public IActionResult Register(User user)
        {
            Console.WriteLine(user.UserName+"이름");
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



        //로그인
        [HttpPost]
        public IActionResult Login(User user)
        {
            bool loginSuccessful = true;

            Console.WriteLine("id : " + user.UserId + " pw :" + user.UserPw);
            var db = new UserDBContext();
            loginSuccessful = db.Login(user);
            
            Console.WriteLine(loginSuccessful + "진짜야 거짓말이야 ?");
            if (loginSuccessful)
            {
                Console.WriteLine(loginSuccessful + "로그인 성공");
                Console.WriteLine(user.UserId+"이름이 잘 들어와");
                HttpContext.Session.SetString("UserId", user.UserId);
                return RedirectToAction("Index", "Membership");
            }
            else
            {
                Console.WriteLine(loginSuccessful + "로그인실패");
                return View("Login");
            }
        }

        //로그인 성공시 화면
        [HttpGet]
        public IActionResult Index()
        {
            var db = new UserDBContext();
            List<string> userNameList = db.Index();
            TempData["UserNames"] = userNameList;
            if (TempData["UserNames"] != null && TempData["UserNames"] is List<string> userNames)
            {
                string userId = HttpContext.Session.GetString("UserId");
                TempData["UserIdValue"] = userId;
                return View(userNames);
            }
            else
            {
                List<string> defaultList = new List<string>() { "No User Names" };
                return View(defaultList);
            }
        }

        //투두리스트 불러오기
        [HttpPost]
        public IActionResult TodoList(User user)
        {
            string userId = HttpContext.Session.GetString("UserId");
            Console.WriteLine($"Todo list: {userId}");

            var db = new UserDBContext();
            List<string> UserTodoList = db.UserTodoList(userId);
            TempData["Contexts"] = UserTodoList;
            if (TempData["Contexts"] != null && TempData["Contexts"] is List<string> Contexts)
            {

                TempData["UserIdValue"] = userId;
                return View(Contexts);
            }
            else
            {
                List<string> defaultList = new List<string>() { "No Context" };
                return View(defaultList);
            }

        
        }

        //투두리스트 내용추가하시
        [HttpPost]
        public string addContext(string context)
        {
            Console.WriteLine($"AddContext: {context}"+"safasf");
            string userId = HttpContext.Session.GetString("UserId");
            using (var db = new UserDBContext())
            {
                try
                {
                    // 사용자 등록 메서드 호출
                    string result = db.addContext(context, userId);

                    return result;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                return "E";
            }

        }

        //리스트 삭제
        [HttpPost]
        public string DeleteContext(string decontext) 
        {
            Console.WriteLine($"AddContext: {decontext}" + "safasf");
            string userId = HttpContext.Session.GetString("UserId");
            using (var db = new UserDBContext())
            {
                try
                {
                    // 사용자 등록 메서드 호출
                    string result = db.DeleteContext(decontext, userId);

                    return result;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                return "E";
            }




        }

        //리스트 수정
        [HttpPost]
        public IActionResult UpdateContext() 
        {


            return View();
        
        }

    }
}
