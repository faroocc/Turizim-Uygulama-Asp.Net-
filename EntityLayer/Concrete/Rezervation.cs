using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervation
    {
        [Key]
        public int RezevationID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
        public string PersonCount { get; set; }
        
        public DateTime Data { get; set; }
        public string Description { get; set; }
        public string Status  { get; set; }
    }
}