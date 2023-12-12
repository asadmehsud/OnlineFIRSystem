using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblSection
{
 public int SectionId { get; set; }
 public string Section { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblSection> GetTblSection()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblSection", prm);
  return dt.DataTableToList<TblSection>();
 }

 public TblSection GetTblSectionById(int SectionId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@SectionId", SectionId);
  DataTable dt = Helper.GetDataTable("Sp_TblSection", prm);
  return dt.DataTableToList<TblSection>().FirstOrDefault();
 }

 public int Insert(TblSection tblsection)
 {
  SqlParameter[] prm = new SqlParameter[3];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@Section", tblsection.Section);
  prm[2] = new SqlParameter("@Status", tblsection.Status);
  return Helper.ExecuteQuery("Sp_TblSection", prm);
 }

 public int Update(TblSection tblsection)
 {
  SqlParameter[] prm = new SqlParameter[4];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@SectionId", tblsection.SectionId);
  prm[2] = new SqlParameter("@Section", tblsection.Section);
  prm[3] = new SqlParameter("@Status", tblsection.Status);
  return Helper.ExecuteQuery("Sp_TblSection", prm);
 }

 public int Delete(int SectionId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@SectionId", SectionId);
  return Helper.ExecuteQuery("Sp_TblSection", prm);
 }
}
}