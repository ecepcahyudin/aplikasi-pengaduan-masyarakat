using Dapper;
using PengaduanMasyarakatApp.DataAccessLibrary.Contracts;

using PengaduanMasyarakatApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.DataAccessLibrary
{
    public class PengaduanData : IPengaduanData
    {
        private readonly ISqlDataAccess _db;

        public PengaduanData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<int> InsertAsync(PengaduanViewModel data)
        {
            var dataTable = new DataTable();
            
            dataTable.Columns.Add("userId");
            dataTable.Columns.Add("judulLaporan");
            dataTable.Columns.Add("laporan");
            dataTable.Columns.Add("foto");
            dataTable.Columns.Add("statusId");

            dataTable.Rows.Add(data.UserId, data.JudulLaporan, data.Laporan, data.Foto, data.StatusId);
            

            var p = new
            {
                data = dataTable.AsTableValuedParameter("pengaduanUDT"),
                id=data.Id,

            };

            return await _db.InsertDataSet<PengaduanViewModel, dynamic>("dbo.sp_pengaduan", dataTable, p);
        }

        public async Task<int> InsertTanggapanAsync(PengaduanViewModel data)
        {
            var dataTable = new DataTable();
            
            dataTable.Columns.Add("pengaduanId");
            dataTable.Columns.Add("tglTanggapan");
            dataTable.Columns.Add("tanggapan");
            dataTable.Columns.Add("petugasId");
            
            dataTable.Rows.Add(data.Id, data.TglTanggapan, data.Tanggapan, data.PetugasId);


            var p = new
            {
                data = dataTable.AsTableValuedParameter("tanggapanUDT"),
                id=data.TanggapanId
            };

            return await _db.InsertDataSet<PengaduanViewModel, dynamic>("dbo.sp_tanggapan", dataTable, p);
        }

        public async Task<List<PengaduanViewModel>> GetAsync(FilterModel filter)
        {
            var p = new
            {
                top = Int16.Parse(filter.Top==null?"0":filter.Top),
                judulLaporan = filter.JudulLaporan,
                tglAwal = filter.TglAwal,
                tglAkhir=filter.TglAkhir,
                statusId=filter.StatusId,
                userId=filter.UserId
            
            };

            string sql = "";

            string queryFilter = "";

            if(!String.IsNullOrEmpty(filter.JudulLaporan))
                queryFilter= " where judulLaporan like '%' + @JudulLaporan +'%' ";

            
            if (!String.IsNullOrEmpty(queryFilter))
            {
                if(filter.TglAwal!=null && filter.TglAkhir != null)
                {
                    queryFilter = queryFilter + " and tglPengaduan between @TglAwal and @TglAkhir ";
                }
                
            }
            else
            {
                if (filter.TglAwal != null && filter.TglAkhir != null)
                {
                    queryFilter = " where tglPengaduan between @TglAwal and @TglAkhir ";
                }
            }

            if (!String.IsNullOrEmpty(queryFilter))
            {
                if (!String.IsNullOrEmpty(filter.StatusId))
                {
                    queryFilter = queryFilter + " and statusId=@StatusId ";
                }

            }
            else
            {
                if (!String.IsNullOrEmpty(filter.StatusId))
                {
                    queryFilter = " where statusId=@StatusId ";
                }
            }

            if (!String.IsNullOrEmpty(queryFilter))
            {
                if (!String.IsNullOrEmpty(filter.UserId))
                {
                    queryFilter = queryFilter + " and userId=@userId ";
                }

            }
            else
            {
                if (!String.IsNullOrEmpty(filter.UserId))
                {
                    queryFilter = " where userId=@userId ";
                }
            }

            if (!String.IsNullOrEmpty(queryFilter))
            {
                if (!String.IsNullOrEmpty(filter.PetugasId))
                {
                    queryFilter = queryFilter + " and petugasId=@petugasId ";
                }

            }
            else
            {
                if (!String.IsNullOrEmpty(filter.PetugasId))
                {
                    queryFilter = " where petugasId=@petugasId ";
                }
            }

            sql = @"select top(@Top) id, tglPengaduan, nik, judulLaporan, laporan, foto, statusID, status, 
                    tanggapanId, tanggapan, userId, email, namaMasyarakat,petugasId, namaPetugas from v_pengaduan " + queryFilter;
            

            return await _db.LoadDataAsync<PengaduanViewModel, dynamic>(sql, p);
        }

        public async Task DeleteAsync(Guid? id)
        {
            var p = new
            {
                id = id
            };

            string sql = @"delete pengaduan_t where id=@Id";
            

            await _db.DeleteData<dynamic>(sql, p);
        }
    }
}
