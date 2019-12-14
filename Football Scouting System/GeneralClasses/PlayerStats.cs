using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Football_Scouting_System.GeneralClasses
{
    public class PlayerStats
    {
        public PlayerStats(int _ID = -1)
        {
            ID = 0;
            Attributes = new int[6];
            if (_ID > -1)
            {
                ID = _ID;
                SetInitialValues(ID);
            }
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int[] Attributes { get; set; } /* [Goals] [Assists] [Games Played] [Minutes Played] [Chances Created] [Match Rating] */
        private void SetInitialValues(int ID)
        {
            Controller controller = new Controller();
            DataTable dt = controller.GetPlayerStats_ID(ID);
            var PlayerAttrib = dt.Rows[0].ItemArray.ToArray(); //itr 0 is for the id
            Name = PlayerAttrib[1].ToString();
            Name +=" "+ PlayerAttrib[2].ToString();
            for (int i = 0; i < 6; i++)
            {
                Attributes[i] = Convert.ToInt32(PlayerAttrib[i + 3]);
            }

        }
    }
}
