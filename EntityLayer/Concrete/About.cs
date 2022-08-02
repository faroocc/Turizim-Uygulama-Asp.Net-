using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        
        public bool Status { get; set; }
    }
}