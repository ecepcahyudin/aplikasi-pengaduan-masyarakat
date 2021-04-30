using System;
using System.Collections.Generic;
using System.Text;

namespace PengaduanMasyarakatApp.Shared.Models
{
    public class PetugasModel
    {
        public string Id { get; set; }
        public string Nama { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Telp { get; set; }
        public string Level { get; set; }
        public bool StatusEnabled { get; set; }

    }
}
