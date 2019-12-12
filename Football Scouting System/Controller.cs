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

        public int insertLeague(int _FA_ID, string _Name)
        {

            string StoredProcedureName = StoredProcedures.InsertLeague;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EfaID", _FA_ID);
            Parameters.Add("@Name", _Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

    }
}
