using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: Contains properties for the attendee, calculates cost and uses getters/setters for each property
 * Date last modified: 22/10/2016
 */

namespace CW1
{
    public class Attendee : Person
    {
        private double attendeeRef;
        private string institutionName;
        private string conferenceName;
        private string regType;
        private bool paid = false;
        private bool presenter = false;
        private string paperTitle;
        private double conferenceCost;
        public double getCost()
        {
            if (regType == "Full")
            {
                conferenceCost = 500;
                if (presenter == true)
                {
                    conferenceCost = conferenceCost - (conferenceCost / 10);
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

        public Attendee()
        {

        }
        
        public double AttendeeRef
        {
            get
            {
                return attendeeRef;
            }
            set
            {
                if (value < 40000 || value > 60000)
                {
                    MessageBox.Show("Invalid Input, must be a number between 40000 - 60000", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                attendeeRef = value;
            }
        }

        public string InstitutionName
        {
            get { return institutionName; }
            set { institutionName = value; }
        }

        public string ConferenceName
        {
            get
            {
                return conferenceName;
            }
            set
            {
                if (value.Length > 0)
                {
                    conferenceName = value;
                }
                else
                {
                    MessageBox.Show("The conference name field cannot be left blank!");
                }
            }
        }

        public string RegType
        {
            get { return regType; }
            set { regType = value; }
        }

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public bool Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        public string PaperTitle
        {
            get { return paperTitle; }
            set { paperTitle = value; }

            /* get
             {
                 return paperTitle;
             }
             set
             {
                 if (presenter == true && paperTitle.Length > 0)
                 {
                     paperTitle = value;
                 } else
                 {
                     MessageBox.Show("As you are a presenter, the paper title field cannot be left blank!");
                 }
             }*/
        }
    }
}
