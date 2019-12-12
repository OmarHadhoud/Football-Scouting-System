using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Scouting_System
{
    public class ValidationClass
    {

        //To use this function
        //String err = "";
        //Object data = ValidationClass.isPositiveInteger("3",err);
       // int x = (int)data;
        public static Object isPositiveInteger(String input,StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int x = Convert.ToInt32(input);
                if (x < 0 )
                {
                    err.Append( "Input " + input + " is a negative number");
                }
                else
                {
                    returnData = x;
                }
            }
            catch
            {
                err.Append( "Input " + input + " is not a valid integer");
            }
            return returnData;
        }

        
    }

    
}
/* CHECK POSITIVE INTEGER
 * StringBuilder err = new StringBuilder() ;
            Object data = ValidationClass.isPositiveInteger(textBox1.Text, err); //choose the textbox to be validated
            if (data == null)
            {
                MessageBox.Show(err.ToString());
            }
            else
            {
                int x = (int)data;
               Call the needed fn. here
            }
 */
/* CHECKING NULL FIELDS
 * if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || string.IsNullOrEmpty(comboBox1.Text))//validation part
		   {
			   MessageBox.Show("Please, insert all values");
		   }
		   else
		   {
			  int r=controllerObj.InsertProject(textBox1.Text.ToString(), Convert.ToInt32(textBox2.Text),textBox3.Text.ToString(),Convert.ToInt32(comboBox1.Text));
			  THE ABOVE LINE IS REPLACED WITH UR NEEDED FN.
			  if (r > 0)
				  MessageBox.Show("Project inserted successfully");
			  else
				  MessageBox.Show("Insertion Failed");
			}

	*/

