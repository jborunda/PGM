using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using PasswordManager.Services;

namespace PasswordManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            Debug.WriteLine("Login controller");
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Debug.WriteLine(email + password);
            return View();
        }
        [HttpGet]
        public IActionResult NewAccount()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewPassword(int input)
        {
            Debug.WriteLine(input);
            ViewData["password"] =  PasswordService.GeneratePassword(input);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
