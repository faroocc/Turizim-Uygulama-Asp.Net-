using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Pay
    {
        [Key]
        public int PayID { get; set; }
        public string PayName { get; set; }
        public string PaySurname { get; set; }
        public string PayTotalPrice { get; set; }
        public DateTime PayDate { get; set; }
        public bool PayStatus { get; set; }
        public int PayCreditNumber { get; set; }
        public int PayCreditDate { get; set; }
        public int PayCvc { get; set; }
        public int DestinationID {get;set;}
        public Destination  Destination { get; set; }
    }
}