using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoomTV.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Signup()
        {
            return View();
        } 
        
        public IActionResult Reset()
        {
            return View();
        }


        




    }
}
