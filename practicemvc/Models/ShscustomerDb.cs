using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class ShscustomerDb
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string CustId { get; set; }
    }
}
