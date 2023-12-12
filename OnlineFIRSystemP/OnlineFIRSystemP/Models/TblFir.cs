using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblFir
{
 public int FirId { get; set; }
 public string AccussedName { get; set; }
 public string AccussedFatherName { get; set; }
 public string AccussedCNIC { get; set; }
 public DateTime DateOfIncident { get; set; }
 public string PlaceOfIncident { get; set; }
 public byte[] Image { get; set; }
 public string IsPoliceVisited { get; set; }
 public DateTime VisitDate { get; set; }
 public string VisitTime { get; set; }
 public string TimeOfIncident { get; set; }
 public int ProvinceId { get; set; }
 public int DistrictId { get; set; }
 public int PoliceStationId { get; set; }
 public string FirDescription { get; set; }
 public string Contact { get; set; }
 public string Email { get; set; }
 public int ComplaintTypeId { get; set; }
 public int SectionId { get; set; }

 public IEnumerable<TblFir> GetTblFir()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblFir", prm);
  return dt.DataTableToList<TblFir>();
 }

 public TblFir GetTblFirById(int FirId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@FirId", FirId);
  DataTable dt = Helper.GetDataTable("Sp_TblFir", prm);
  return dt.DataTableToList<TblFir>().FirstOrDefault();
 }

 public int Insert(TblFir tblfir)
 {
  SqlParameter[] prm = new SqlParameter[19];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@AccussedName", tblfir.AccussedName);
  prm[2] = new SqlParameter("@AccussedFatherName", tblfir.AccussedFatherName);
  prm[3] = new SqlParameter("@AccussedCNIC", tblfir.AccussedCNIC);
  prm[4] = new SqlParameter("@DateOfIncident", tblfir.DateOfIncident);
  prm[5] = new SqlParameter("@PlaceOfIncident", tblfir.PlaceOfIncident);
  prm[6] = new SqlParameter("@Image", tblfir.Image);
  prm[7] = new SqlParameter("@IsPoliceVisited", tblfir.IsPoliceVisited);
  prm[8] = new SqlParameter("@VisitDate", tblfir.VisitDate);
  prm[9] = new SqlParameter("@VisitTime", tblfir.VisitTime);
  prm[10] = new SqlParameter("@TimeOfIncident", tblfir.TimeOfIncident);
  prm[11] = new SqlParameter("@ProvinceId", tblfir.ProvinceId);
  prm[12] = new SqlParameter("@DistrictId", tblfir.DistrictId);
  prm[13] = new SqlParameter("@PoliceStationId", tblfir.PoliceStationId);
  prm[14] = new SqlParameter("@FirDescription", tblfir.FirDescription);
  prm[15] = new SqlParameter("@Contact", tblfir.Contact);
  prm[16] = new SqlParameter("@Email", tblfir.Email);
  prm[17] = new SqlParameter("@ComplaintTypeId", tblfir.ComplaintTypeId);
  prm[18] = new SqlParameter("@SectionId", tblfir.SectionId);
  return Helper.ExecuteQuery("Sp_TblFir", prm);
 }

 public int Update(TblFir tblfir)
 {
  SqlParameter[] prm = new SqlParameter[20];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@FirId", tblfir.FirId);
  prm[2] = new SqlParameter("@AccussedName", tblfir.AccussedName);
  prm[3] = new SqlParameter("@AccussedFatherName", tblfir.AccussedFatherName);
  prm[4] = new SqlParameter("@AccussedCNIC", tblfir.AccussedCNIC);
  prm[5] = new SqlParameter("@DateOfIncident", tblfir.DateOfIncident);
  prm[6] = new SqlParameter("@PlaceOfIncident", tblfir.PlaceOfIncident);
  prm[7] = new SqlParameter("@Image", tblfir.Image);
  prm[8] = new SqlParameter("@IsPoliceVisited", tblfir.IsPoliceVisited);
  prm[9] = new SqlParameter("@VisitDate", tblfir.VisitDate);
  prm[10] = new SqlParameter("@VisitTime", tblfir.VisitTime);
  prm[11] = new SqlParameter("@TimeOfIncident", tblfir.TimeOfIncident);
  prm[12] = new SqlParameter("@ProvinceId", tblfir.ProvinceId);
  prm[13] = new SqlParameter("@DistrictId", tblfir.DistrictId);
  prm[14] = new SqlParameter("@PoliceStationId", tblfir.PoliceStationId);
  prm[15] = new SqlParameter("@FirDescription", tblfir.FirDescription);
  prm[16] = new SqlParameter("@Contact", tblfir.Contact);
  prm[17] = new SqlParameter("@Email", tblfir.Email);
  prm[18] = new SqlParameter("@ComplaintTypeId", tblfir.ComplaintTypeId);
  prm[19] = new SqlParameter("@SectionId", tblfir.SectionId);
  return Helper.ExecuteQuery("Sp_TblFir", prm);
 }

 public int Delete(int FirId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@FirId", FirId);
  return Helper.ExecuteQuery("Sp_TblFir", prm);
 }
}
}