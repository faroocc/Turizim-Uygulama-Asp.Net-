using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TraversalCoreUi.Models;

namespace TraversalCoreUi.Controllers
{   
     [AllowAnonymous]

    public class LoginController : Controller
    {
        private readonly  SignInManager<AppUser> _signManager;
        public LoginController(SignInManager<AppUser> signManager)
        {
            _signManager=signManager;
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
         [HttpPost]
        public async Task<IActionResult> Login(LoginUserModel p)
        {
          if (ModelState.IsValid)
          {
            var result = await _signManager.PasswordSignInAsync(p.UserName,p.PassWord,false,true);
            if (result.Succeeded)
            {
                return RedirectToAction("index","Profile",new{area = "Member"});
            }else{
                return View();
            }
          }  
          return View();
        }

       
    }
}