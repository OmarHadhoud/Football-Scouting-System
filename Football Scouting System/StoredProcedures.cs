using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Scouting_System
{
    public class StoredProcedures
    {
        //FA related procedures
        public static string InsertFA = "InsertFA";
        public static string UpdateFAPassword = "UpdateFAPassword";
        public static string UpdateFAEmail = "UpdateFAEmail";
        public static string UpdateFAAddress = "UpdateFAAddress";
        public static string AddFATelNum = "AddFATelNum";
        public static string GetFreePlayerOffers = "GetFreePlayerOffers";
        public static string GetFreeScoutsOffers = "GetFreeScoutsOffers";
        public static string DeleteC2EPOffer = "DeleteC2EPOffer";
        public static string DeleteC2ESOffer = "DeleteC2ESOffer";
        public static string UpdateLeagueStanding = "UpdateLeagueStanding";
        
        //League related procedures
        public static string InsertLeague = "insertLeague";
        public static string GetLeagues = "GetLeagues";
        //Club related procedures
        public static string InsertClub = "InsertClub";
        public static string GetClubs = "GetClubs";
        public static string GetAllClubs = "GetAllClubs";
        public static string GetPlayers = "GetPlayers";
        public static string DeletePlayer = "DeletePlayer";
        public static string UpdateClubLeague = "UpdateClubLeague";
		public static string Approachfreeplayer = "Approachfreeplayer";
		public static string Approachnonfreeplayer = "Approachnonfreeplayer";
		public static string GetEfa = "GetEfa";
		public static string Getclubidplayer = "Getclubidplayer";
		public static string GetActualOffers = "getactualplayersoffer";
		public static string GetSuggestedfreeOffers = "getsuggestedfreeplayersoffer";
		public static string GetSuggestednonfreeOffers = "getsuggestednonfreeplayersoffer";
		public static string DeleteC2COffer = "DeleteC2COffer";
		public static string DeleteC2EOffer = "DeleteC2EOffer";
		public static string approveC2EOffer = "approveC2EOffer";
		public static string approveC2COffer = "approveC2COffer";





		//Staff related
        public static string GetClubNews = "GetClubNews";


        

        //Staff related
        public static string AddScout = "AddScout";
        public static string AddManager = "AddManager";
        public static string AddJournalist = "AddJournalist";
        public static string AddAgent = "AddAgent";
        public static string AddCoach = "AddCoach";
        public static string GetAgents = "GetAgents";
        public static string GetManagers = "GetManagers";
        public static string GetCoaches = "GetCoaches";
        public static string AddLicense = "AddLicense";
        public static string DeleteAgent = "DeleteAgent";
        public static string DeleteCoach = "DeleteCoach";
        public static string DeleteManager = "DeleteManager";
        public static string GetAllJournalists = "GetAllJournalists";
        public static string GetIndpJournalists = "GetIndpJournalists";
        public static string GetArticlesBy = "GetArticlesBy";

        //Scout related procedures
        public static string Order_search_PlayerForScouts = "Order_search_PlayerForScouts";
        public static string Order_Search_Club = "Order_Search_Club";
        public static string GetScoutWithID = "GetScoutWithID";
        public static string GetAvgAttrib = "GetAvgAttrib";
        public static string GetPlayerStats_ID = "GetPlayerStats_ID";
        public static string AddPlayerRating = "AddPlayerRating";
        public static string UpsertPlayerAttributes = "UpsertPlayerAttributes";
        public static string HasAttributes = "HasAttributes";
        public static string GetPlayerName_ID = "GetPlayerName_ID";
        public static string ScoutReqSigningC2C = "ScoutReqSigningC2C";
        public static string ScoutReqSigningC2E = "ScoutReqSigningC2E";
        public static string GetPlayerClub = "GetPlayerClub";
        public static string GetScoutClub_ID = "GetScoutClub_ID";
        public static string ScoutReqWorkingC2E = "ScoutReqWorkingC2E";
        public static string UpdateScoutPassword = "UpdateScoutPassword";
        public static string GetScoutsSignings = "GetScoutsSignings";



		public static string EndorseScout = "Endorsenonsignedscout";

		//Counting functions
		public static string GetCountOfScouts = "GetCountOfScouts";
        public static string GetCountOfJournalists = "GetCountOfJournalists";
        public static string GetCountOfFA = "GetCountOfFA";
        public static string GetCountOfCoaches = "GetCountOfCoaches";
        public static string GetCountOFClubs = "GetCountOFClubs";
        public static string GetCountOfAgents = "GetCountOfAgents";
        public static string GetCountOfManagers = "GetCountOfManagers";
        public static string GetCountOfLicenseNumbers = "GetCountOfLicenseNumbers";
		public static string GetCountOfprofplayers = "GetCountOfProfPlayers";
		public static string GetCountOFnews = "GetCountOFnews";
		public static string GetCountOFarticless = "GetCountOFarticles";


        //ID related functions
		public static string GetLastID = "GetLastID";
        public static string GetLastIdOfScouts = "GetLastIdOfScouts";
        public static string GetLastIdOfJournalists = "GetLastIdOfJournalists";
        public static string GetLastIdOfFA = "GetLastIdOfFA";
        public static string GetLastIdOfCoaches = "GetLastIdOfCoaches";
        public static string GetLastIdOFClubs = "GetLastIdOFClubs";
        public static string GetLastIdOfAgents = "GetLastIdOfAgents";
        public static string GetLastIdOfManagers = "GetLastIdOfManagers";
        public static string GetLastIdOfLicenseNumbers = "GetLastIdOfLicenseNumbers";
        public static string GetLastIdOfprofplayers = "GetLastIdOfProfPlayers";
        public static string GetLastIdOFnews = "GetLastIdOFnews";
        public static string GetLastIdOFarticless = "GetLastIdOFarticles";



        //Player related procedures
        public static string InsertPlayer = "Addplayer";
		public static string InsertYouthPlayer = "AddYouthplayer";

		public static string GetPlayerclub = "Getplayerclubid";
		public static string UpdatePlayerStatus = "updatestatus";
		public static string SetPlayerClub = "SetPlayerClub";
		public static string GetAllfreePlayers = "GetAllfreePlayers";
		public static string GetAllnonfreePlayers = "GetAllnonfreePlayers";
		public static string GetafreePlayer = "GetafreePlayerproc";
		public static string GetanonfreePlayer = "GetanonfreePlayerproc";

		//Journalist
		public static string InsertArticless = "insertarticles";
		public static string Journalistrequest = "addjournalisttoclub";

		





		//news
		public static string InsertNews = "insertnews";

        //scout
        public static string SetScoutClub = "SetScoutClub";

        //LogInRelated
        public static string LogInFA= "LogInFA";
        public static string LogInClub = "LogInClub";
        public static string LogInScout = "LogInScout";
        public static string LogInJournalist = "LogInJournalist";



    }
}
