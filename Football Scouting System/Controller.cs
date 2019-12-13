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
            if (_LeagueName == "-1")
                Parameters.Add("LeagueName", null);
            else
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

        public DataTable GetPlayers()
        {
            string StoredProcedureName = StoredProcedures.GetPlayers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
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

        public int DeletePlayer(int _PID)
        {

            string StoredProcedureName = StoredProcedures.DeletePlayer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", _PID);
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

        //Staff related functions
        public int AddManager(int _MID, string _Name, DateTime _Bdate, string _Nationality, int _ClubID, int _AgentID)
        {

            string StoredProcedureName = StoredProcedures.AddManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MID", _MID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Bdate", _Bdate);
            Parameters.Add("@Nationality", _Nationality);
            if (_ClubID == -1)
                Parameters.Add("@ClubID", null);
            else
                Parameters.Add("@ClubID", _ClubID);
            if (_AgentID == -1)
                Parameters.Add("AgentID", null);
            else
                Parameters.Add("@AgentID", _AgentID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddCoach(int _CID, string _Name, DateTime _Bdate, int _ClubID, int _LicenseNumber)
        {

            string StoredProcedureName = StoredProcedures.AddCoach;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Bdate", _Bdate);
            if (_ClubID == -1)
                Parameters.Add("@ClubID", null);
            else
                Parameters.Add("@ClubID", _ClubID);
            Parameters.Add("@LicenseNumber", _LicenseNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int AddJournalist(int _JID, string _Name, DateTime _Bdate, string _Password)
        {

            string StoredProcedureName = StoredProcedures.AddJournalist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@JID", _JID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Bdate", _Bdate);
            Parameters.Add("@Password", _Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int AddAgent(int _AID, string _Name, DateTime _Bdate, int _LicenseNumber)
        {

            string StoredProcedureName = StoredProcedures.AddAgent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AID", _AID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Bdate", _Bdate);
            Parameters.Add("@LicenseNumber", _LicenseNumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        

        public int AddScout(int _SID, string _Name, DateTime _Bdate, int _Endorses, string _Password, int _ClubID, int _LicenseNumber)
        {

            string StoredProcedureName = StoredProcedures.AddScout;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SID", _SID);
            Parameters.Add("@Name", _Name);
            Parameters.Add("@Bdate", _Bdate);
            Parameters.Add("@LicenseNumber", _LicenseNumber);
            Parameters.Add("@Endorses", _Endorses);
            Parameters.Add("@password", _Password);
            if (_ClubID == -1)
                Parameters.Add("@ClubID", null);
            else
                Parameters.Add("@ClubID", _ClubID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddLicense(int _LN)
        {

            string StoredProcedureName = StoredProcedures.AddLicense;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LN", _LN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAgents()
        {
            string StoredProcedureName = StoredProcedures.GetAgents;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetManagers()
        {
            string StoredProcedureName = StoredProcedures.GetManagers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetCoaches()
        {
            string StoredProcedureName = StoredProcedures.GetCoaches;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int DeleteAgent(int _AID)
        {

            string StoredProcedureName = StoredProcedures.DeleteAgent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AID", _AID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteManager(int _MID)
        {

            string StoredProcedureName = StoredProcedures.DeleteManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MID", _MID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int DeleteCoach(int _CID)
        {

            string StoredProcedureName = StoredProcedures.DeleteCoach;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        //Counting functions
        public int GetCountOfScouts()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfScouts;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int GetCountOfJournalists()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfJournalists;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        
        public int GetCountOfFA()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfFA;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        
        public int GetCountOfCoaches()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfCoaches;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        
        public int GetCountOFClubs()
        {
            string StoredProcedureName = StoredProcedures.GetCountOFClubs;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        
        public int GetCountOfAgents()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfAgents;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        
        public int GetCountOfManagers()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfManagers;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int GetCountOfLicenseNumbers()
        {
            string StoredProcedureName = StoredProcedures.GetCountOfLicenseNumbers;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }


    }
}
