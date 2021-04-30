using PengaduanMasyarakatApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.DataAccessLibrary.Contracts
{
    public interface IPengaduanData
    {
        Task<int> InsertAsync(PengaduanViewModel datas);
        Task<int> InsertTanggapanAsync(PengaduanViewModel data);
        Task<List<PengaduanViewModel>> GetAsync(FilterModel filter);
        Task DeleteAsync(Guid? id);
    }
}