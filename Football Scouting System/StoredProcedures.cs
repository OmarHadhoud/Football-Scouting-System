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
        //League related procedures
        public static string InsertLeague = "insertLeague";
        public static string GetLeagues = "GetLeagues";
        //Club related procedures
        public static string InsertClub = "InsertClub";
        public static string GetClubs = "GetClubs";
        public static string UpdateClubLeague = "UpdateClubLeague";
        //Staff related
        public static string AddManager = "AddManager";
        public static string AddScout = "AddScout";
        public static string AddJournalist = "AddJournalist";
        public static string AddAgent = "AddAgent";
        public static string AddCoach = "AddCoach";

        //Scout related procedures
        public static string Order_search_PlayerForScouts = "Order_search_PlayerForScouts";
    }
}
