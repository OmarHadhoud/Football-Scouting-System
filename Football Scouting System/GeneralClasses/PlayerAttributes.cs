using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Football_Scouting_System.GeneralClasses
{
    public class PlayerAttributes
    {
        public PlayerAttributes(int _ID = -1)
        {
            ID = 0;
            Attributes = new int[12];
            if (_ID > -1)
            {
                ID = _ID;
                SetInitialValues(ID);
            }
        }
        public int ID { get; set; }
        public int[] Attributes { get; set; } /*[Pace] [Acceleration] [Strength] [Jumping] [Shooting] [Passing] [Dribbling] [Positionning] [Off the ball] [Goalkeeper handling] [Goalkeeper positioning] [Goalkeeper decisions]*/
        private void SetInitialValues(int ID)
        {
            Controller controller = new Controller();
            DataTable dt = controller.GetAvgAttrib(ID);
            var PlayerAttrib = dt.Rows[0].ItemArray.ToArray(); //itr 0 is for the id
            for (int i = 0; i < 12; i++) 
            {
                Attributes[i] =Convert.ToInt32(PlayerAttrib[i+1]); 
            }
            
        }
    }
}
