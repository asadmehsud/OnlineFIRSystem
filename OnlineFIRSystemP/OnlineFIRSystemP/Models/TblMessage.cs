using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLibrary.DL;
using BusinessLibrary.BL;
using System.Linq;

namespace OnlineFIRSystemProject.Models
{
public class TblMessage
{
 public int MessageId { get; set; }
 public int ProvinceId { get; set; }
 public int DistrictId { get; set; }
 public int PoliceStationId { get; set; }
 public string Message { get; set; }
 public DateTime PostedDate { get; set; }
 public string Reply { get; set; }
 public string Seen { get; set; }

 public IEnumerable<TblMessage> GetTblMessage()
 {
  SqlParameter[] prm = new SqlParameter[1];
  prm[0] = new SqlParameter("@Type", 4);
  DataTable dt = Helper.GetDataTable("Sp_TblMessage", prm);
  return dt.DataTableToList<TblMessage>();
 }

 public TblMessage GetTblMessageById(int MessageId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 4);
  prm[1] = new SqlParameter("@MessageId", MessageId);
  DataTable dt = Helper.GetDataTable("Sp_TblMessage", prm);
  return dt.DataTableToList<TblMessage>().FirstOrDefault();
 }

 public int Insert(TblMessage tblmessage)
 {
  SqlParameter[] prm = new SqlParameter[8];
  prm[0] = new SqlParameter("@Type", 1);
  prm[1] = new SqlParameter("@ProvinceId", tblmessage.ProvinceId);
  prm[2] = new SqlParameter("@DistrictId", tblmessage.DistrictId);
  prm[3] = new SqlParameter("@PoliceStationId", tblmessage.PoliceStationId);
  prm[4] = new SqlParameter("@Message", tblmessage.Message);
  prm[5] = new SqlParameter("@PostedDate", tblmessage.PostedDate);
  prm[6] = new SqlParameter("@Reply", tblmessage.Reply);
  prm[7] = new SqlParameter("@Seen", tblmessage.Seen);
  return Helper.ExecuteQuery("Sp_TblMessage", prm);
 }

 public int Update(TblMessage tblmessage)
 {
  SqlParameter[] prm = new SqlParameter[9];
  prm[0] = new SqlParameter("@Type", 2);
  prm[1] = new SqlParameter("@MessageId", tblmessage.MessageId);
  prm[2] = new SqlParameter("@ProvinceId", tblmessage.ProvinceId);
  prm[3] = new SqlParameter("@DistrictId", tblmessage.DistrictId);
  prm[4] = new SqlParameter("@PoliceStationId", tblmessage.PoliceStationId);
  prm[5] = new SqlParameter("@Message", tblmessage.Message);
  prm[6] = new SqlParameter("@PostedDate", tblmessage.PostedDate);
  prm[7] = new SqlParameter("@Reply", tblmessage.Reply);
  prm[8] = new SqlParameter("@Seen", tblmessage.Seen);
  return Helper.ExecuteQuery("Sp_TblMessage", prm);
 }

 public int Delete(int MessageId)
 {
  SqlParameter[] prm = new SqlParameter[2];
  prm[0] = new SqlParameter("@Type", 3);
  prm[1] = new SqlParameter("@MessageId", MessageId);
  return Helper.ExecuteQuery("Sp_TblMessage", prm);
 }
}
}