using PengaduanMasyarakatApp.DataAccessLibrary.Contracts;

using PengaduanMasyarakatApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.DataAccessLibrary
{
    public class GlobalData : IGlobalData
    {
        private readonly ISqlDataAccess _db;

        public GlobalData(ISqlDataAccess db)
        {
            _db = db;
        }


        public async Task<List<StatusModel>> GetStatussAsync()
        {

            string sql = @"select * from status_s where statusEnabled=1";


            return await _db.LoadDataAsync<StatusModel, dynamic>(sql, new { });
        }

        public async Task<List<PetugasModel>> GetPetugassAsync()
        {

            string sql = @"select id, nama from v_petugas";


            return await _db.LoadDataAsync<PetugasModel, dynamic>(sql, new { });
        }

    }
}
