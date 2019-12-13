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
        //League related procedures
        public static string InsertLeague = "insertLeague";
        public static string GetLeagues = "GetLeagues";
        //Club related procedures
        public static string InsertClub = "InsertClub";
        public static string GetClubs = "GetClubs";
        public static string UpdateClubLeague = "UpdateClubLeague";
		//Player related procedures
		public static string InsertPlayer = "Addplayerbeta";
		public static string GetPlayerclub = "Getplayerclubid";
		public static string UpdatePlayerStatus = "updatestatus";

		//news
		public static string InsertNews = "insertnews";

		//scout
		public static string EndorseScout = "Endorsenonsignedscout";



	}
}
