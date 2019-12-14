using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Football_Scouting_System.GeneralClasses
{
    public class Scout
    {

        public Scout(int ID=-1)
        {
            if (ID>-1)
            {
                SetInitialValues(ID);
            }
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Endorses { get; set; }
        public String Club { get; set; }
        public String Password { get; set; }
        public int LicenseNumber { get; set; }


        private void SetInitialValues(int ID)
        {
            Controller controller = new Controller();
            DataTable dt = controller.GetScoutWithID(ID);
            var ScoutInfo = dt.Rows[0].ItemArray.ToArray();
            Name = Convert.ToString(ScoutInfo[0]);
            BirthDate = Convert.ToDateTime(ScoutInfo[1]);
            Endorses = Convert.ToInt32(ScoutInfo[2]);
            Club = Convert.ToString(ScoutInfo[3]);
            Password = Convert.ToString(ScoutInfo[4]);
            LicenseNumber = Convert.ToInt32(ScoutInfo[5]);
        }
    }
}
