using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TraversalCoreUi.Areas.Member.Models
{
    public class UserEditProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string phonenumber { get; set; }
        public IFormFile imageUrl { get; set; }
        public string Mail { get; set; }
    }
}