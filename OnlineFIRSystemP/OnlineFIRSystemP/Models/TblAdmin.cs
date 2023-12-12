using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblAdmin
{
 public int AdminId { get; set; }
 public int DistrictId { get; set; }
 public int ProvinceId { get; set; }
 public int PoliceStationId { get; set; }
 public int UnitId { get; set; }
 public string Name { get; set; }
 public string UserName { get; set; }
 public string Password { get; set; }
 public string Email { get; set; }
 public string CNIC { get; set; }
 public string Contact { get; set; }
 public int Status { get; set; }
 public int DesignationId { get; set; }
 public byte[] Image { get; set; }

 public IEnumerable<TblAdmin> GetTblAdmin()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblAdmin", prm);
  return dt.DataTableToList<TblAdmin>();
 }

 public TblAdmin GetTblAdminById(int AdminId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@AdminId", AdminId);
  DataTable dt = Helper.GetDataTable("Sp_TblAdmin", prm);
  return dt.DataTableToList<TblAdmin>().FirstOrDefault();
 }

 public int Insert(TblAdmin tbladmin)
 {
  SqlParameter[] prm = new SqlParameter[14];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@DistrictId", tbladmin.DistrictId);
  prm[2] = new SqlParameter("@ProvinceId", tbladmin.ProvinceId);
  prm[3] = new SqlParameter("@PoliceStationId", tbladmin.PoliceStationId);
  prm[4] = new SqlParameter("@UnitId", tbladmin.UnitId);
  prm[5] = new SqlParameter("@Name", tbladmin.Name);
  prm[6] = new SqlParameter("@UserName", tbladmin.UserName);
  prm[7] = new SqlParameter("@Password", tbladmin.Password);
  prm[8] = new SqlParameter("@Email", tbladmin.Email);
  prm[9] = new SqlParameter("@CNIC", tbladmin.CNIC);
  prm[10] = new SqlParameter("@Contact", tbladmin.Contact);
  prm[11] = new SqlParameter("@Status", tbladmin.Status);
  prm[12] = new SqlParameter("@DesignationId", tbladmin.DesignationId);
  prm[13] = new SqlParameter("@Image", tbladmin.Image);
  return Helper.ExecuteQuery("Sp_TblAdmin", prm);
 }

 public int Update(TblAdmin tbladmin)
 {
  SqlParameter[] prm = new SqlParameter[15];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@AdminId", tbladmin.AdminId);
  prm[2] = new SqlParameter("@DistrictId", tbladmin.DistrictId);
  prm[3] = new SqlParameter("@ProvinceId", tbladmin.ProvinceId);
  prm[4] = new SqlParameter("@PoliceStationId", tbladmin.PoliceStationId);
  prm[5] = new SqlParameter("@UnitId", tbladmin.UnitId);
  prm[6] = new SqlParameter("@Name", tbladmin.Name);
  prm[7] = new SqlParameter("@UserName", tbladmin.UserName);
  prm[8] = new SqlParameter("@Password", tbladmin.Password);
  prm[9] = new SqlParameter("@Email", tbladmin.Email);
  prm[10] = new SqlParameter("@CNIC", tbladmin.CNIC);
  prm[11] = new SqlParameter("@Contact", tbladmin.Contact);
  prm[12] = new SqlParameter("@Status", tbladmin.Status);
  prm[13] = new SqlParameter("@DesignationId", tbladmin.DesignationId);
  prm[14] = new SqlParameter("@Image", tbladmin.Image);
  return Helper.ExecuteQuery("Sp_TblAdmin", prm);
 }

 public int Delete(int AdminId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@AdminId", AdminId);
  return Helper.ExecuteQuery("Sp_TblAdmin", prm);
 }
}
}