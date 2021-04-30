using PengaduanMasyarakatApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.DataAccessLibrary.Contracts
{
    public interface IGlobalData
    {
        Task<List<StatusModel>> GetStatussAsync();
        Task<List<PetugasModel>> GetPetugassAsync();
    }
}