using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblPoliceStation
{
 public int PoliceStationId { get; set; }
 public string PoliceStation { get; set; }
 public int ProvinceId { get; set; }
 public int DistrictId { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblPoliceStation> GetTblPoliceStation()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblPoliceStation", prm);
  return dt.DataTableToList<TblPoliceStation>();
 }

 public TblPoliceStation GetTblPoliceStationById(int PoliceStationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@PoliceStationId", PoliceStationId);
  DataTable dt = Helper.GetDataTable("Sp_TblPoliceStation", prm);
  return dt.DataTableToList<TblPoliceStation>().FirstOrDefault();
 }

 public int Insert(TblPoliceStation tblpolicestation)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@PoliceStation", tblpolicestation.PoliceStation);
  prm[2] = new SqlParameter("@ProvinceId", tblpolicestation.ProvinceId);
  prm[3] = new SqlParameter("@DistrictId", tblpolicestation.DistrictId);
  prm[4] = new SqlParameter("@Status", tblpolicestation.Status);
  return Helper.ExecuteQuery("Sp_TblPoliceStation", prm);
 }

 public int Update(TblPoliceStation tblpolicestation)
 {
  SqlParameter[] prm = new SqlParameter[6];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@PoliceStationId", tblpolicestation.PoliceStationId);
  prm[2] = new SqlParameter("@PoliceStation", tblpolicestation.PoliceStation);
  prm[3] = new SqlParameter("@ProvinceId", tblpolicestation.ProvinceId);
  prm[4] = new SqlParameter("@DistrictId", tblpolicestation.DistrictId);
  prm[5] = new SqlParameter("@Status", tblpolicestation.Status);
  return Helper.ExecuteQuery("Sp_TblPoliceStation", prm);
 }

 public int Delete(int PoliceStationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@PoliceStationId", PoliceStationId);
  return Helper.ExecuteQuery("Sp_TblPoliceStation", prm);
 }
}
}