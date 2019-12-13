using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Football_Scouting_System
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //FA related functions
        public int insertFA(int _FA_ID, string _Email, string _Address, string _Password)
        {
            string StoredProcedureName = StoredProcedures.InsertFA;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@Email", _Email);
            Parameters.Add("@Address", _Address);
            Parameters.Add("@Password", _Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateFAPassword(int _FA_ID, string _Password)
        {
            string StoredProcedureName = StoredProcedures.UpdateFAPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@Password", _Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateFAEmail(int _FA_ID, string _Email)
        {
            string StoredProcedureName = StoredProcedures.UpdateFAEmail;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@Email", _Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateFAAddress(int _FA_ID, string _Address)
        {
            string StoredProcedureName = StoredProcedures.UpdateFAAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@Address", _Address);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int InsertTelNum(int _FA_ID, string _TelNum)
        {
            string StoredProcedureName = StoredProcedures.AddFATelNum;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@TelNum", _TelNum);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        //League related functions
        public int insertLeague(int _FA_ID, string _Name)
        {

            string StoredProcedureName = StoredProcedures.InsertLeague;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EfaID", _FA_ID);
            Parameters.Add("@Name", _Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetLeagues(int _FA_ID)
        {
            string StoredProcedureName = StoredProcedures.GetLeagues;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //Club related functions
        public int insertClub(int _CID, string _Name, string _Abbv, string _City, string _LeagueName, int _FA_ID, DateTime _FD, string _Pass)
        {

            string StoredProcedureName = StoredProcedures.InsertClub;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Abbreviation", _Abbv);
            Parameters.Add("@City", _City);
            Parameters.Add("@LeagueName", _LeagueName);
            Parameters.Add("@League_EFAID", _FA_ID);
            Parameters.Add("@Foundation_Date", _FD);
            Parameters.Add("@Password", _Pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetClubs(int _FA_ID)
        {
            string StoredProcedureName = StoredProcedures.GetClubs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UpdateClubLeague(int _CID, int _FA_ID, string _LeagueName)
        {
            string StoredProcedureName = StoredProcedures.UpdateClubLeague;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@LeagueName", _LeagueName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //Scout related functions
        public DataTable Order_search_PlayerForScouts(int order, string NameKeyWord)
        {
            string StoredProcedureName = StoredProcedures.Order_search_PlayerForScouts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderby", order);
            Parameters.Add("@inputN", NameKeyWord);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}
