using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemP.Models
{
    public class TblProvince
    {
        public int ProvinceId { get; set; }
        public string Province { get; set; }
        public int Status { get; set; }

        public IEnumerable<TblProvince> GetTblProvince()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            DataTable dt = Helper.GetDataTable("Sp_TblProvince", prm);
            return dt.DataTableToList<TblProvince>();
        }

        public TblProvince GetTblProvinceById(int ProvinceId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", 4);
            prm[1] = new SqlParameter("@ProvinceId", ProvinceId);
            DataTable dt = Helper.GetDataTable("Sp_TblProvince", prm);
            return dt.DataTableToList<TblProvince>().FirstOrDefault();
        }

        public int Insert(TblProvince tblprovince)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", 1);
            prm[1] = new SqlParameter("@Province", tblprovince.Province);
            prm[2] = new SqlParameter("@Status", tblprovince.Status);
            return Helper.ExecuteQuery("Sp_TblProvince", prm);
        }

        public int Update(TblProvince tblprovince)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Type", 2);
            prm[1] = new SqlParameter("@ProvinceId", tblprovince.ProvinceId);
            prm[2] = new SqlParameter("@Province", tblprovince.Province);
            prm[3] = new SqlParameter("@Status", tblprovince.Status);
            return Helper.ExecuteQuery("Sp_TblProvince", prm);
        }

        public int Delete(int ProvinceId)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", 3);
            prm[1] = new SqlParameter("@ProvinceId", ProvinceId);
            return Helper.ExecuteQuery("Sp_TblProvince", prm);
        }
    }
}