using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: Contains properties for the attendee, calculates cost and uses getters/setters for each property
 * Date last modified: 23/10/2016
 */

namespace CW1
{
    public class Attendee : Person
    {
        private double attendeeRef;
        private string conferenceName;                      // Initialise variables with default values
        private string regType;
        private bool paid = false;
        private bool presenter = false;
        private string paperTitle;
        private double conferenceCost;

        public double getCost()
        {
            if (regType == "Full")                          // The drop down menu items in the GUI will parse the user's selection to a string
            {                                               // therefore the input can be checked by "Full", "Student" or "Organiser".
                conferenceCost = 500;
                if (presenter == true)
                {
                    conferenceCost = conferenceCost - (conferenceCost / 10);        // Remove 10% from cost if the attendee is a presenter
                }
            }

            if (regType == "Student")
            {
                conferenceCost = 300;
                if (presenter == true)
                {
                    conferenceCost = conferenceCost - (conferenceCost / 10);
                }
            }

            if (regType == "Organiser")
            {
                conferenceCost = 0;
            }

            return conferenceCost;
        }
        
        public double AttendeeRef                                     // Property used to store the Attendee reference number
        {
            get
            {
                return attendeeRef;
            }
            set
            {
                if (value < 40000 || value > 60000)                   // Validation for attendee ref, so that the value isn't outwith the given range. If it is, an error box will appear
                {
                    MessageBox.Show("Invalid Input, attendee ref must be a number between 40000 - 60000", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                attendeeRef = value;
            }
        }

        public string FirstName                                       // Property used to store the Attendee first name
        {
            get
            {
                return Person.firstName;                              // Name properties are stored and updated in the Person class
            }                                                         // Use properties to check
            set
            {
                if (value.Length > 0)                                 // if the text box is not empty.
                {
                    Person.firstName = value;
                }
                else
                {
                    MessageBox.Show("The first name field cannot be left blank!");      // If it is empty, an error will appear.
                }
            }
        }

        public string SecondName                                       // Property used to store the Attendee second name
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
        
        public string ConferenceName                                       // Property used to store the name of the conference (attended)
        {
            get
            {
                return conferenceName;
            }
            set
            {
                if (value.Length > 0)                                      // Simple check to see if the field is blank
                {
                    conferenceName = value;
                }
                else
                {
                    MessageBox.Show("The conference name field cannot be left blank!");         // If it is, an error will appear and the variable won't be updated.
                }
            }
        }

        public string InstitutionName                                       // Property used to store the name of the institution
        {
            get { return Institution.institutionName; }
            set { Institution.institutionName = value; }
        }
        
        public string InstitutionAddress
        {
            get { return Institution.institutionAddress; }                  // Values for the institution name and address
            set { Institution.institutionAddress = value; }                 // are stored in the institution class.
        }

        public string RegType                                               // Property used to store the registration type of the attendee
        {
            get { return regType; }
            set { regType = value; }
        }

        public bool Paid                                                    // Property used to store the status of whether the attendee has paid or not
        {
            get { return paid; }
            set { paid = value; }
        }

        public bool Presenter                                               // Property used to store the status of whether the attendee is a presenter or not
        {
            get { return presenter; }
            set { presenter = value; }
        }

        public string PaperTitle                                            // Property used to store the name of the presented paper
        {
            get { return paperTitle; }
            set { paperTitle = value; }
        }
    }
}
