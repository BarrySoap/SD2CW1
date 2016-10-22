using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: Encompass the name properties, test inheritance to Attendee.cs
 * Date last modified: 22/10/2016
 */

namespace CW1
{
    public class Person
    {
        private string firstName;                           // Initialise the name variables
        private string secondName;

        public string FirstName
        {
            get
            {
                return firstName;
            }                                               // Use properties to check
            set
            
                if (value.Length > 0)                       // if the text box is not empty.
                {
                    firstName = value;
                }
                else
                {
                    MessageBox.Show("The first name field cannot be left blank!");      // If it is empty, an error will appear.
                }
            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (value.Length > 0)
                {
                    secondName = value;
                }
                else
                {
                    MessageBox.Show("The last name field cannot be left blank!");
                }
            }
        }
    }
}
