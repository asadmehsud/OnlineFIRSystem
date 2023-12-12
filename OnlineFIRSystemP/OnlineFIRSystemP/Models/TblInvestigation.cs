using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblInvestigation
{
 public int InvestigationId { get; set; }
 public string Subject { get; set; }
 public string Detail { get; set; }
 public DateTime PostedDate { get; set; }

 public IEnumerable<TblInvestigation> GetTblInvestigation()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblInvestigation", prm);
  return dt.DataTableToList<TblInvestigation>();
 }

 public TblInvestigation GetTblInvestigationById(int InvestigationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@InvestigationId", InvestigationId);
  DataTable dt = Helper.GetDataTable("Sp_TblInvestigation", prm);
  return dt.DataTableToList<TblInvestigation>().FirstOrDefault();
 }

 public int Insert(TblInvestigation tblinvestigation)
 {
  SqlParameter[] prm = new SqlParameter[4];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@Subject", tblinvestigation.Subject);
  prm[2] = new SqlParameter("@Detail", tblinvestigation.Detail);
  prm[3] = new SqlParameter("@PostedDate", tblinvestigation.PostedDate);
  return Helper.ExecuteQuery("Sp_TblInvestigation", prm);
 }

 public int Update(TblInvestigation tblinvestigation)
 {
  SqlParameter[] prm = new SqlParameter[5];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@InvestigationId", tblinvestigation.InvestigationId);
  prm[2] = new SqlParameter("@Subject", tblinvestigation.Subject);
  prm[3] = new SqlParameter("@Detail", tblinvestigation.Detail);
  prm[4] = new SqlParameter("@PostedDate", tblinvestigation.PostedDate);
  return Helper.ExecuteQuery("Sp_TblInvestigation", prm);
 }

 public int Delete(int InvestigationId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@InvestigationId", InvestigationId);
  return Helper.ExecuteQuery("Sp_TblInvestigation", prm);
 }
}
}