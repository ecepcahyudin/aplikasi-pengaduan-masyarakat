using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PengaduanMasyarakatApp
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string IdCardNumber { get; set; }
    }
}
