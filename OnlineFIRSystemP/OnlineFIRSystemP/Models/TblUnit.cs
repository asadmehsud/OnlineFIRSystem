using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblUnit
{
 public int UnitId { get; set; }
 public string Unit { get; set; }
 public int ProvinceId { get; set; }
 public int DistrictId { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblUnit> GetTblUnit()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblUnit", prm);
  return dt.DataTableToList<TblUnit>();
 }

 public TblUnit GetTblUnitById(int UnitId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@UnitId", UnitId);
  DataTable dt = Helper.GetDataTable("Sp_TblUnit", prm);
  return dt.DataTableToList<TblUnit>().FirstOrDefault();
 }

 public int Insert(TblUnit tblunit)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@Unit", tblunit.Unit);
  prm[2] = new SqlParameter("@ProvinceId", tblunit.ProvinceId);
  prm[3] = new SqlParameter("@DistrictId", tblunit.DistrictId);
  prm[4] = new SqlParameter("@Status", tblunit.Status);
  return Helper.ExecuteQuery("Sp_TblUnit", prm);
 }

 public int Update(TblUnit tblunit)
 {
  SqlParameter[] prm = new SqlParameter[6];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@UnitId", tblunit.UnitId);
  prm[2] = new SqlParameter("@Unit", tblunit.Unit);
  prm[3] = new SqlParameter("@ProvinceId", tblunit.ProvinceId);
  prm[4] = new SqlParameter("@DistrictId", tblunit.DistrictId);
  prm[5] = new SqlParameter("@Status", tblunit.Status);
  return Helper.ExecuteQuery("Sp_TblUnit", prm);
 }

 public int Delete(int UnitId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@UnitId", UnitId);
  return Helper.ExecuteQuery("Sp_TblUnit", prm);
 }
}
}