using System;
using System.Collections.Generic;
using System.Text;

namespace PengaduanMasyarakatApp.Shared.Models
{
    public class PengaduanViewModel
    {
        public Guid? Id { get; set; }
        public DateTime TglPengaduan { get; set; }
        public string UserId { get; set; }
        public string NIK { get; set; }
        public string JudulLaporan { get; set; }
        public string Laporan { get; set; }
        public string Foto { get; set; }
        public string StatusId { get; set; }
        public string Status { get; set; }
        public bool IsLolosVerifikasiValidasi { get; set; }
        public string PetugasId { get; set; }
        public DateTime? TglTanggapan { get; set; }
        public Guid? TanggapanId { get; set; }
        public string Tanggapan { get; set; }
        public string Email { get; set; }
        public string NamaMasyarakat { get; set; }
        public string NamaPetugas { get; set; }

        public string LinkReport
        { 
            
            get {
                return "/DownloadPdf?pageName=pengaduan?id=" + Id;
            }

            set
            {

            } 
        }
    }
}
