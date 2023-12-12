using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblDesignation
{
 public int DesignationId { get; set; }
 public string Designation { get; set; }
 public int ProvinceId { get; set; }
 public int DistrictId { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblDesignation> GetTblDesignation()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblDesignation", prm);
  return dt.DataTableToList<TblDesignation>();
 }

 public TblDesignation GetTblDesignationById(int DesignationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@DesignationId", DesignationId);
  DataTable dt = Helper.GetDataTable("Sp_TblDesignation", prm);
  return dt.DataTableToList<TblDesignation>().FirstOrDefault();
 }

 public int Insert(TblDesignation tbldesignation)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@Designation", tbldesignation.Designation);
  prm[2] = new SqlParameter("@ProvinceId", tbldesignation.ProvinceId);
  prm[3] = new SqlParameter("@DistrictId", tbldesignation.DistrictId);
  prm[4] = new SqlParameter("@Status", tbldesignation.Status);
  return Helper.ExecuteQuery("Sp_TblDesignation", prm);
 }

 public int Update(TblDesignation tbldesignation)
 {
  SqlParameter[] prm = new SqlParameter[6];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@DesignationId", tbldesignation.DesignationId);
  prm[2] = new SqlParameter("@Designation", tbldesignation.Designation);
  prm[3] = new SqlParameter("@ProvinceId", tbldesignation.ProvinceId);
  prm[4] = new SqlParameter("@DistrictId", tbldesignation.DistrictId);
  prm[5] = new SqlParameter("@Status", tbldesignation.Status);
  return Helper.ExecuteQuery("Sp_TblDesignation", prm);
 }

 public int Delete(int DesignationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@DesignationId", DesignationId);
  return Helper.ExecuteQuery("Sp_TblDesignation", prm);
 }
}
}