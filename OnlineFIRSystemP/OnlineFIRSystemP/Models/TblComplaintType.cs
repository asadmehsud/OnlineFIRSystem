using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblComplaintType
{
 public int ComplaintTypeId { get; set; }
 public string Type { get; set; }
 public int Status { get; set; }

 public IEnumerable<TblComplaintType> GetTblComplaintType()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblComplaintType", prm);
  return dt.DataTableToList<TblComplaintType>();
 }

 public TblComplaintType GetTblComplaintTypeById(int ComplaintTypeId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@ComplaintTypeId", ComplaintTypeId);
  DataTable dt = Helper.GetDataTable("Sp_TblComplaintType", prm);
  return dt.DataTableToList<TblComplaintType>().FirstOrDefault();
 }

 public int Insert(TblComplaintType tblcomplainttype)
 {
  SqlParameter[] prm = new SqlParameter[3];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@Type", tblcomplainttype.Type);
  prm[2] = new SqlParameter("@Status", tblcomplainttype.Status);
  return Helper.ExecuteQuery("Sp_TblComplaintType", prm);
 }

 public int Update(TblComplaintType tblcomplainttype)
 {
  SqlParameter[] prm = new SqlParameter[4];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@ComplaintTypeId", tblcomplainttype.ComplaintTypeId);
  prm[2] = new SqlParameter("@Type", tblcomplainttype.Type);
  prm[3] = new SqlParameter("@Status", tblcomplainttype.Status);
  return Helper.ExecuteQuery("Sp_TblComplaintType", prm);
 }

 public int Delete(int ComplaintTypeId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@ComplaintTypeId", ComplaintTypeId);
  return Helper.ExecuteQuery("Sp_TblComplaintType", prm);
 }
}
}