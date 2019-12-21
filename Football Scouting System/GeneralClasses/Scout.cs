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

        public Scout(int ID_=-1)
        {
            if (ID_>-1)
            {
                SetInitialValues(ID_);
                ID = ID_;
            }
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Endorses { get; set; }
        public String Club { get; set; }
        public String Password { get; set; }
        public int LicenseNumber { get; set; }


        private void SetInitialValues(int ID)
        {
            try { 
            Controller controller = new Controller();
            DataTable dt = controller.GetScoutWithID(ID);
            var ScoutInfo = dt.Rows[0].ItemArray.ToArray();
            Name = Convert.ToString(ScoutInfo[0]);
            try{ BirthDate = Convert.ToDateTime(ScoutInfo[1]);}
            catch { BirthDate = Convert.ToDateTime("1 / 1 / 1753"); }
            Endorses = Convert.ToInt32(ScoutInfo[2]);
            Club = Convert.ToString(ScoutInfo[3]);
            Password = Convert.ToString(ScoutInfo[4]);
            LicenseNumber = Convert.ToInt32(ScoutInfo[5]);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error, Scout"+ID+" data not found");
                Name = "Error not found";
                BirthDate =Convert.ToDateTime("2000-2-2");
                LicenseNumber = -1;
                Endorses = -1;
                Club = "Error not found";
                Password = "Error";
                throw;
            }
        }
    }
}
