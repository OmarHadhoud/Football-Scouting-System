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
        public static string GetClubNews = "GetClubNews";
        

        //Staff related
        public static string AddManager = "AddManager";
        public static string AddScout = "AddScout";
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



		//Player related procedures
		public static string InsertPlayer = "Addplayer";
		public static string InsertYouthPlayer = "AddYouthplayer";

		public static string GetPlayerclub = "Getplayerclubid";
		public static string UpdatePlayerStatus = "updatestatus";
		public static string SetPlayerClub = "SetPlayerClub";
		public static string GetAllfreePlayers = "GetAllfreePlayers";
		public static string GetAllnonfreePlayers = "GetAllnonfreePlayers";



		//news
		public static string InsertNews = "insertnews";

        //scout
        public static string SetScoutClub = "SetScoutClub";



    }
}
