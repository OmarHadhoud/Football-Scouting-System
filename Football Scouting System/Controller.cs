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

        public DataTable GetFreePlayerOffers(int _FA_ID)
        {
            string StoredProcedureName = StoredProcedures.GetFreePlayerOffers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetFreeScoutOffers(int _FA_ID)
        {
            string StoredProcedureName = StoredProcedures.GetFreeScoutsOffers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int DeleteC2EPOffer(int _FA_ID, int _SCID,int _PID)
        {
            string StoredProcedureName = StoredProcedures.DeleteC2EPOffer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@SCID", _SCID);
            Parameters.Add("@PID", _PID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteC2ESOffer(int _FA_ID, int _SCID, int _SID)
        {
            string StoredProcedureName = StoredProcedures.DeleteC2ESOffer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FA_ID", _FA_ID);
            Parameters.Add("@SCID", _SCID);
            Parameters.Add("@SID", _SID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateLeagueStanding(int _FA_ID, string _LeagueName, string _Standing)
        {
            string StoredProcedureName = StoredProcedures.UpdateLeagueStanding;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FAID", _FA_ID);
            Parameters.Add("@LeagueName", _LeagueName);
            Parameters.Add("@Stnding", _Standing);
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

        public DataTable GetAllClubs()
        {
            string StoredProcedureName = StoredProcedures.GetAllClubs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetPlayers()
        {
            string StoredProcedureName = StoredProcedures.GetPlayers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetClubNews(int _CID)
        {
            string StoredProcedureName = StoredProcedures.GetClubNews;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cid", _CID);
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

        public int DeletePlayer(int _PID)
        {

            string StoredProcedureName = StoredProcedures.DeletePlayer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", _PID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

		public int AddOffer(int _clubid,int _efaid,int _playerid,DateTime _date,int _fee,int _suggest)
		{

			string StoredProcedureName = StoredProcedures.Approachfreeplayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@clubid", _clubid);
			Parameters.Add("@efaid", _efaid);
			Parameters.Add("@player", _playerid);
			Parameters.Add("@feein", _fee);
			Parameters.Add("@datein", _date);
			Parameters.Add("@suggest", _suggest);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int AddnonfreeOffer(int _clubid, int _recid, int _playerid, DateTime _date, int _fee, int _suggest)
		{

			string StoredProcedureName = StoredProcedures.Approachnonfreeplayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@clubid", _clubid);
			Parameters.Add("@recid", _recid);
			Parameters.Add("@player", _playerid);
			Parameters.Add("@feein", _fee);
			Parameters.Add("@datein", _date);
			Parameters.Add("@suggest", _suggest);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int Getclubid(int _playerid)
		{
			string StoredProcedureName = StoredProcedures.Getclubidplayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@playerid", _playerid);
			return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);

		}

		public int Getefa(int _clubid)
		{
			string StoredProcedureName = StoredProcedures.GetEfa;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@clubid", _clubid);
			return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);

		}

		public DataTable GetactualOffers(int _club)
		{
			string StoredProcedureName = StoredProcedures.GetActualOffers;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@club", _club);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetsuggestedfreeOffers(int _club)
		{
			string StoredProcedureName = StoredProcedures.GetSuggestedfreeOffers;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@club", _club);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}
		public DataTable GetsuggestednonfreeOffers(int _club)
		{
			string StoredProcedureName = StoredProcedures.GetSuggestednonfreeOffers;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@club", _club);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}
		public int DeleteC2COffer(int _REC, int _SCID, int _PID)
		{
			string StoredProcedureName = StoredProcedures.DeleteC2COffer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@REC", _REC);
			Parameters.Add("@SCID", _SCID);
			Parameters.Add("@PID", _PID);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int DeleteC2EOffer(int _FA_ID, int _SCID, int _PID)
		{
			string StoredProcedureName = StoredProcedures.DeleteC2EOffer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@FA_ID", _FA_ID);
			Parameters.Add("@SCID", _SCID);
			Parameters.Add("@PID", _PID);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int approvesuggestion(int _FA_ID, int _SCID, int _PID)
		{
			string StoredProcedureName = StoredProcedures.approveC2EOffer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@FA_ID", _FA_ID);
			Parameters.Add("@SCID", _SCID);
			Parameters.Add("@PID", _PID);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int approvenonfreesuggestion(int _REC, int _SCID, int _PID)
		{
			string StoredProcedureName = StoredProcedures.approveC2COffer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@REC", _REC);
			Parameters.Add("@SCID", _SCID);
			Parameters.Add("@PID", _PID);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public DataTable GetAllScouts()
		{
			string StoredProcedureName = StoredProcedures.GetAllscouts;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			return dbMan.ExecuteReader(StoredProcedureName, null);
		}

		public DataTable GetfreeScouts()
		{
			string StoredProcedureName = StoredProcedures.Getfreescouts;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			return dbMan.ExecuteReader(StoredProcedureName, null);
		}

		public int AddScoutOffer(int _clubid, int _efaid, int _scout, DateTime _date, int _fee, int _suggest)
		{

			string StoredProcedureName = StoredProcedures.Approachfreescout;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@clubid", _clubid);
			Parameters.Add("@efaid", _efaid);
			Parameters.Add("@scoutid", _scout);
			Parameters.Add("@feein", _fee);
			Parameters.Add("@datein", _date);
			Parameters.Add("@suggest", _suggest);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		//Scout related functions
		public DataTable Order_search_PlayerForScouts(int order, string NameKeyWord,int dir)
        {
            string StoredProcedureName = StoredProcedures.Order_search_PlayerForScouts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderby", order);
            Parameters.Add("@inputN", NameKeyWord);
            Parameters.Add("@OrderDir", dir);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Order_Search_Club (int order, string NameKeyWord, int dir)
        {
            string StoredProcedureName = StoredProcedures.Order_Search_Club;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderby", order);
            Parameters.Add("@inputN", NameKeyWord);
            Parameters.Add("@OrderDir", dir);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetScoutWithID(int id)
        {
            string StoredProcedureName = StoredProcedures.GetScoutWithID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAvgAttrib(int id)
        {
            string StoredProcedureName = StoredProcedures.GetAvgAttrib;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetPlayerStats_ID(int id)
        {
            string StoredProcedureName = StoredProcedures.GetPlayerStats_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int AddPlayerRating(int PlayerID,int ScoutID,int Pace,int Acceleration,int Strength,int Jumping,int Shooting,int Passing,int Dribbling	,int Positionning,int otb,int gkh,int gkp ,int gkd)
        {
            string StoredProcedureName = StoredProcedures.AddPlayerRating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PlayerID", PlayerID		);
            Parameters.Add("@ScoutID", ScoutID		);
            Parameters.Add("@Pace", Pace			);
            Parameters.Add("@Acceleration", Acceleration	);
            Parameters.Add("@Strength", Strength		);
            Parameters.Add("@Jumping", Jumping		);
            Parameters.Add("@Shooting", Shooting		);
            Parameters.Add("@Passing", Passing		);
            Parameters.Add("@Dribbling", Dribbling	);
            Parameters.Add("@Positionning", Positionning	);
            Parameters.Add("@otb", otb			);
            Parameters.Add("@gkh", gkh			);
            Parameters.Add("@gkp", gkp			);
            Parameters.Add("@gkd", gkd          );
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpsertPlayerAttributes(int PlayerID, int ScoutID, int Pace, int Acceleration, int Strength, int Jumping, int Shooting, int Passing, int Dribbling, int Positionning, int otb, int gkh, int gkp, int gkd)
        {
            string StoredProcedureName = StoredProcedures.UpsertPlayerAttributes;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PlayerID", PlayerID);
            Parameters.Add("@ScoutID", ScoutID);
            Parameters.Add("@Pace", Pace);
            Parameters.Add("@Acceleration", Acceleration);
            Parameters.Add("@Strength", Strength);
            Parameters.Add("@Jumping", Jumping);
            Parameters.Add("@Shooting", Shooting);
            Parameters.Add("@Passing", Passing);
            Parameters.Add("@Dribbling", Dribbling);
            Parameters.Add("@Positionning", Positionning);
            Parameters.Add("@otb", otb);
            Parameters.Add("@gkh", gkh);
            Parameters.Add("@gkp", gkp);
            Parameters.Add("@gkd", gkd);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public bool HasAttributes(int PlayerID, int ScoutID)
        {
            string StoredProcedureName = StoredProcedures.HasAttributes;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PlayerID);
            Parameters.Add("@SID", ScoutID);
            return Convert.ToBoolean(dbMan.ExecuteScalar(StoredProcedureName, Parameters));
        }
        public DataTable GetPlayerName_ID(int id)
        {
            string StoredProcedureName = StoredProcedures.GetPlayerName_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int GetPlayerClub(int PlayerID)
        {
            string StoredProcedureName = StoredProcedures.GetPlayerClub;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PlayerID);
            return Convert.ToInt32(dbMan.ExecuteScalar(StoredProcedureName, Parameters));
        }
        public int GetScoutClub_ID(int SID)
        {
            string StoredProcedureName = StoredProcedures.GetScoutClub_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SID", SID);
            return Convert.ToInt32(dbMan.ExecuteScalar(StoredProcedureName, Parameters));
        }
        public int ScoutReqSigningC2C(int PID, int ScoutID, int CIDSend, int CIDRecive, int Fee)
        {
            string StoredProcedureName = StoredProcedures.ScoutReqSigningC2C;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID1", CIDSend);
            Parameters.Add("@CID2",CIDRecive );
            Parameters.Add("@PID", PID);
            Parameters.Add("@Fee", Fee);
            Parameters.Add("@Sid", ScoutID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ScoutReqSigningC2E(int PID, int ScoutID, int CID, int EFAID, int Fee)
        {
            string StoredProcedureName = StoredProcedures.ScoutReqSigningC2E;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            Parameters.Add("@EFAID", EFAID);
            Parameters.Add("@PID", PID);
            Parameters.Add("@Fee", Fee);
            Parameters.Add("@Sid", ScoutID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ScoutReqWorkingC2E(int ScoutID, int CID, int EFAID, int Fee)
        {
            string StoredProcedureName = StoredProcedures.ScoutReqWorkingC2E;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            Parameters.Add("@EFAID", EFAID);
            Parameters.Add("@SID", ScoutID);
            Parameters.Add("@Fee", Fee);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateScoutPassword(int SID, string _Password)
        {
            string StoredProcedureName = StoredProcedures.UpdateScoutPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SID", SID);
            Parameters.Add("@Password", _Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetScoutsSignings(int SID)
        {
            string StoredProcedureName = StoredProcedures.GetScoutsSignings;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SID", SID);
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

        public DataTable GetArticlesBy(int _JID)
        {
            string StoredProcedureName = StoredProcedures.GetArticlesBy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@JID", _JID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
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

        public DataTable GetIndpJournalists()
        {
            string StoredProcedureName = StoredProcedures.GetIndpJournalists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllJournalists()
        {
            string StoredProcedureName = StoredProcedures.GetAllJournalists;
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

		public int GetCountOfProfPlayers()
		{
			string StoredProcedureName = StoredProcedures.GetCountOfprofplayers;
			return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
		}

		public int GetCountOfnews()
		{
			string StoredProcedureName = StoredProcedures.GetCountOFnews;
			return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
		}

		public int GetCountOfarticles()
		{
			string StoredProcedureName = StoredProcedures.GetCountOFarticless;
			return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
		}

        public int GetLastID()
        {
            string StoredProcedureName = StoredProcedures.GetLastID;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        //Journalist


        public int insertarticle(int _no, int _id, DateTime _foundationdate, string _title, string _text)
		{
			string StoredProcedureName = StoredProcedures.InsertArticless;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@articlesno", _no);
			Parameters.Add("@id", _id);
			Parameters.Add("@date", _foundationdate);
			Parameters.Add("@tit", _title);
			Parameters.Add("@text", _text);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int journalistrequest(int _JID,int _CID)
		{
			string StoredProcedureName = StoredProcedures.Journalistrequest;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Journalist", _JID);
			Parameters.Add("@club", _CID);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}


		//News


		public int insertnews(int _no, int _id,DateTime _foundationdate,string _title,string _text)
		{
			string StoredProcedureName = StoredProcedures.InsertNews;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@newsno",_no);
			Parameters.Add("@id", _id);
			Parameters.Add("@date", _foundationdate);
			Parameters.Add("@tit", _title);
			Parameters.Add("@text", _text);
			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}
		//players
		public int insertPlayer(string _fname,string _mname,string _lname,string _bplace,string _nationality,DateTime _bdate,int _age,double _height,int _games,int _minutes,double _rating,string _status,int _id,int _clubid)
		{
			

			string StoredProcedureName = StoredProcedures.InsertPlayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@fname", _fname);
			Parameters.Add("@mname", _mname);
			Parameters.Add("@lname", _lname);
			Parameters.Add("@bdate", _bdate);
			//Parameters.Add("@age", _age);
			Parameters.Add("@bplace", _bplace);
			Parameters.Add("@nationality", _nationality);
			Parameters.Add("@height", _height);
			Parameters.Add("@status", _status);
			Parameters.Add("@games", _games);
			Parameters.Add("@minutes", _minutes);
			Parameters.Add("@rating", _rating);
			Parameters.Add("@id", _id);
			Parameters.Add("@clubid", _clubid);

			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public int insertYouthPlayer(string _fname, string _mname, string _lname, string _bplace, string _nationality, DateTime _bdate, int _age, double _height, int _games, int _minutes, double _rating, string _status, int _id, int _clubid)
		{


			string StoredProcedureName = StoredProcedures.InsertYouthPlayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@fname", _fname);
			Parameters.Add("@mname", _mname);
			Parameters.Add("@lname", _lname);
			Parameters.Add("@bdate", _bdate);
			//Parameters.Add("@age", _age);
			Parameters.Add("@bplace", _bplace);
			Parameters.Add("@nationality", _nationality);
			Parameters.Add("@height", _height);
			Parameters.Add("@status", _status);
			Parameters.Add("@games", _games);
			Parameters.Add("@minutes", _minutes);
			Parameters.Add("@rating", _rating);
			Parameters.Add("@id", _id);
			Parameters.Add("@clubid", _clubid);

			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

		public DataTable GetPlayers(int _Club_ID)
		{
			string StoredProcedureName = StoredProcedures.GetPlayerclub;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@CID", _Club_ID);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}
		public int UpdateStatus(string _status,int _playerID)
		{
			string StoredProcedureName = StoredProcedures.UpdatePlayerStatus;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@stat", _status);
			Parameters.Add("@ID", _playerID);

			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

        public int SetPlayerClub(int _CID, int _PID)
        {
            string StoredProcedureName = StoredProcedures.SetPlayerClub;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            Parameters.Add("@PID", _PID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

		public DataTable GetAllFreePlayers()
		{
			string StoredProcedureName = StoredProcedures.GetAllfreePlayers;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetaFreePlayer(string name)
		{
			string StoredProcedureName = StoredProcedures.GetafreePlayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@inputN", name);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetAllNonFreePlayers()
		{
			string StoredProcedureName = StoredProcedures.GetAllnonfreePlayers;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetanonFreePlayer(string name)
		{
			string StoredProcedureName = StoredProcedures.GetanonfreePlayer;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@inputN", name);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		//scout
		public int Endorsenonsigned(int _ID)
		{
			string StoredProcedureName = StoredProcedures.EndorseScout;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@id", _ID);

			return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
		}

        public int SetScoutClub(int _CID, int _SID)
        {
            string StoredProcedureName = StoredProcedures.SetScoutClub;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", _CID);
            Parameters.Add("@SID", _SID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        //Login functions
        public int LogInFA(int _ID, string _pass)
        {
            string StoredProcedureName = StoredProcedures.LogInFA;
            Dictionary<string, object> Paramateres = new Dictionary<string, object>();
            Paramateres.Add("@ID", _ID);
            Paramateres.Add("@pass", _pass);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Paramateres);
        }

        public int LogInScout(int _ID, string _pass)
        {
            string StoredProcedureName = StoredProcedures.LogInScout;
            Dictionary<string, object> Paramateres = new Dictionary<string, object>();
            Paramateres.Add("@ID", _ID);
            Paramateres.Add("@pass", _pass);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Paramateres);
        }

        public int LogInClub(int _ID, string _pass)
        {
            string StoredProcedureName = StoredProcedures.LogInClub;
            Dictionary<string, object> Paramateres = new Dictionary<string, object>();
            Paramateres.Add("@ID", _ID);
            Paramateres.Add("@pass", _pass);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Paramateres);
        }

        public int LogInJournalist(int _ID, string _pass)
        {
            string StoredProcedureName = StoredProcedures.LogInJournalist;
            Dictionary<string, object> Paramateres = new Dictionary<string, object>();
            Paramateres.Add("@ID", _ID);
            Paramateres.Add("@pass", _pass);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Paramateres);
        }
    }
}
