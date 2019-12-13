﻿using System;
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
        public static string GetAgents = "GetAgents";
        public static string AddLicense = "AddLicense";
        //Scout related procedures
        public static string Order_search_PlayerForScouts = "Order_search_PlayerForScouts";







        //Counting functions
        public static string GetCountOfScouts = "GetCountOfScouts";
        public static string GetCountOfJournalists = "GetCountOfJournalists";
        public static string GetCountOfFA = "GetCountOfFA";
        public static string GetCountOfCoaches = "GetCountOfCoaches";
        public static string GetCountOFClubs = "GetCountOFClubs";
        public static string GetCountOfAgents = "GetCountOfAgents";
        public static string GetCountOfManagers = "GetCountOfManagers";
        public static string GetCountOfLicenseNumbers = "GetCountOfLicenseNumbers";

    }
}
