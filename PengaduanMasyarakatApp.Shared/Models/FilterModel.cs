using System;
using System.Collections.Generic;
using System.Text;

namespace PengaduanMasyarakatApp.Shared.Models
{
    public class FilterModel
    {
        public string Top { get; set; }
        public string JudulLaporan { get; set; }
        public DateTime? TglAwal { get; set; }
        public DateTime? TglAkhir { get; set; }
        public string StatusId { get; set; }
        public string UserId { get; set; }
        public string PetugasId { get; set; }
    }
}
