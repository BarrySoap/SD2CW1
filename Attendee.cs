using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: Contains properties for the attendee, calculates cost and uses getters/setters for each property
 * Date last modified: 10/10/2016
 */

namespace CW1
{
    public class Attendee : Person
    {
        private double attendeeRef;
        private string firstName;
        private string secondName;
        private string institutionName;
        private string conferenceName;
        private string regType;
        private bool paid = false;
        private bool presenter = false;
        private string paperTitle;
        private double conferenceCost;

        public int getCost()
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

            return 0;
        }

        public Attendee(double attref, string fn, string sn, string inst, string conf, string regt, bool pad, bool prese, string papr)
        {
            attendeeRef = attref;
            firstName = fn;
            secondName = sn;
            institutionName = inst;
            conferenceName = conf;
            regType = regt;
            paid = pad;
            presenter = prese;
            paperTitle = papr;
        }
         
        public Attendee()
        {

        }
        
        public double AttendeeRef
        {
            get { return attendeeRef; }
            set { attendeeRef = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public string InstitutionName
        {
            get { return institutionName; }
            set { institutionName = value; }
        }

        public string ConferenceName
        {
            get { return conferenceName; }
            set { conferenceName = value; }
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
        }
    }
}
