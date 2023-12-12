using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblDistrict
{
 public int DistrictId { get; set; }
 public string District { get; set; }
 public int ProvinceId { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblDistrict> GetTblDistrict()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblDistrict", prm);
  return dt.DataTableToList<TblDistrict>();
 }

 public TblDistrict GetTblDistrictById(int DistrictId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@DistrictId", DistrictId);
  DataTable dt = Helper.GetDataTable("Sp_TblDistrict", prm);
  return dt.DataTableToList<TblDistrict>().FirstOrDefault();
 }

 public int Insert(TblDistrict tbldistrict)
 {
  SqlParameter[] prm = new SqlParameter[4];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@District", tbldistrict.District);
  prm[2] = new SqlParameter("@ProvinceId", tbldistrict.ProvinceId);
  prm[3] = new SqlParameter("@Status", tbldistrict.Status);
  return Helper.ExecuteQuery("Sp_TblDistrict", prm);
 }

 public int Update(TblDistrict tbldistrict)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@DistrictId", tbldistrict.DistrictId);
  prm[2] = new SqlParameter("@District", tbldistrict.District);
  prm[3] = new SqlParameter("@ProvinceId", tbldistrict.ProvinceId);
  prm[4] = new SqlParameter("@Status", tbldistrict.Status);
  return Helper.ExecuteQuery("Sp_TblDistrict", prm);
 }

 public int Delete(int DistrictId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@DistrictId", DistrictId);
  return Helper.ExecuteQuery("Sp_TblDistrict", prm);
 }
}
}