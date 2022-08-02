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
    public class RegisterController : Controller
    {
       private readonly  UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager=userManager;
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserModel p)
        {
          AppUser appUser = new AppUser()
          {
            Name=p.Name,
            Surname=p.SurName,
            Email=p.Mail,
            UserName=p.UserName
          };
          if (p.Password == p.ConfirmPassword)
          {
            var result = await _userManager.CreateAsync(appUser,p.Password);
            if (result.Succeeded)
            {
              return RedirectToAction("Login","Login");
            }else{
              foreach (var item in result.Errors)
              {
                 ModelState.AddModelError("",item.Description);
              }
            }
          }
          return View(p);
        }
    }
}