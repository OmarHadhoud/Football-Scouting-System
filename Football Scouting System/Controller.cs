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
    }
}
