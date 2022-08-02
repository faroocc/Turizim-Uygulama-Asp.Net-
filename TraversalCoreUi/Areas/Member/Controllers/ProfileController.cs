using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TraversalCoreUi.Areas.Member.Models;

namespace TraversalCoreUi.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditProfile userEditProfile = new UserEditProfile();
            userEditProfile.Name = values.Name;
            userEditProfile.Surname = values.Surname;
            userEditProfile.phonenumber= values.PhoneNumber;
            userEditProfile.Mail=values.Email;
            return View(userEditProfile);
        }
        public async Task<IActionResult> Index(UserEditProfile p)
        {
          var user = await _userManager.FindByNameAsync(User.Identity.Name);
          if (p.imageUrl != null)
          {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(p.imageUrl.FileName);
            var imagename = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/userimages"+ imagename;
            var stream = new FileStream(saveLocation,FileMode.Create);
            await p.imageUrl.CopyToAsync(stream);
            user.ImageUrl = imagename;
          }  
          user.Name=p.Name;
          user.Surname=p.Surname;
          user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,p.password);
          var result = await _userManager.UpdateAsync(user);
          if (result.Succeeded)
          {
            return RedirectToAction("login","login");
          }
          return View();
        }

       
    }
}