using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblInvestigationOfficer
{
 public int InvestigationOfficerId { get; set; }
 public int AdminId { get; set; }
 public int FirId { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblInvestigationOfficer> GetTblInvestigationOfficer()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblInvestigationOfficer", prm);
  return dt.DataTableToList<TblInvestigationOfficer>();
 }

 public TblInvestigationOfficer GetTblInvestigationOfficerById(int InvestigationOfficerId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@InvestigationOfficerId", InvestigationOfficerId);
  DataTable dt = Helper.GetDataTable("Sp_TblInvestigationOfficer", prm);
  return dt.DataTableToList<TblInvestigationOfficer>().FirstOrDefault();
 }

 public int Insert(TblInvestigationOfficer tblinvestigationofficer)
 {
  SqlParameter[] prm = new SqlParameter[4];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@AdminId", tblinvestigationofficer.AdminId);
  prm[2] = new SqlParameter("@FirId", tblinvestigationofficer.FirId);
  prm[3] = new SqlParameter("@Status", tblinvestigationofficer.Status);
  return Helper.ExecuteQuery("Sp_TblInvestigationOfficer", prm);
 }

 public int Update(TblInvestigationOfficer tblinvestigationofficer)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@InvestigationOfficerId", tblinvestigationofficer.InvestigationOfficerId);
  prm[2] = new SqlParameter("@AdminId", tblinvestigationofficer.AdminId);
  prm[3] = new SqlParameter("@FirId", tblinvestigationofficer.FirId);
  prm[4] = new SqlParameter("@Status", tblinvestigationofficer.Status);
  return Helper.ExecuteQuery("Sp_TblInvestigationOfficer", prm);
 }

 public int Delete(int InvestigationOfficerId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@InvestigationOfficerId", InvestigationOfficerId);
  return Helper.ExecuteQuery("Sp_TblInvestigationOfficer", prm);
 }
}
}