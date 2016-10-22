using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: This is the GUI of the program, allows the user to easily enter data, remove data, etc.
 * Date last modified: 22/10/2016
 */

namespace CW1
{
    public partial class MainWindow : Window
    {
        Attendee attendee1 = new Attendee();                            // Creating the attendee object

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)         // Encompasses the code executed when the user presses 'Set' on the GUI
        {
            double tempnum;
            attendee1.FirstName = txtName1.Text;
            attendee1.SecondName = txtName2.Text;
            attendee1.InstitutionName = txtInstitution.Text;
            attendee1.ConferenceName = txtConference.Text;
            attendee1.PaperTitle = txtTitle.Text;

            if (Double.TryParse(txtAttendee.Text, out tempnum))
            {
                attendee1.AttendeeRef = Double.Parse(txtAttendee.Text);     // This block of code will test the contents of the attendeeRef text box to
            }
            else                                                          // check if it is either: not blank/not a string. If the content of the box is a valid
            {                                                               // number, the variable will take the value. If not, an error message will appear.
                MessageBox.Show("Please enter a valid number!");
            }

            switch (cmbReg.SelectedIndex)
            {
                case -1:
                    break;                                                  // This case statement will take the selected value of the drop-down
                case 0:                                                     // menu and place it in the "attendee1.RegType" variable. This avoids any
                    attendee1.RegType = "Full";                             // hassle with indexes or parsing.
                    break;
                case 1:
                    attendee1.RegType = "Student";
                    break;
                case 2:
                    attendee1.RegType = "Organiser";
                    break;
            }

            if (checkPaid.IsChecked == true)
            {
                attendee1.Paid = true;                                      // Simple check to see if the check box is checked or not.
            }

            if (checkPresenter.IsChecked == true)
            {
                attendee1.Presenter = true;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)       // Encompasses the code executed when the user presses 'Clear' on the GUI
        {
            txtName1.Text = "";
            txtName2.Text = "";
            txtAttendee.Text = "";
            txtInstitution.Text = "";                                       // Clear all of the fields by setting all of the values
            txtConference.Text = "";                                        // to nothing.
            checkPaid.IsChecked = false;
            checkPresenter.IsChecked = false;                               // Or uncheck.
            cmbReg.SelectedIndex = -1;
            txtTitle.Text = "";
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)         // Encompasses the code executed when the user presses 'Get' on the GUI
        {
            txtName1.Text = attendee1.FirstName;
            txtName2.Text = attendee1.SecondName;                           // Updating all of the variables to the values of
            txtAttendee.Text = attendee1.AttendeeRef.ToString();            // the class.
            txtInstitution.Text = attendee1.InstitutionName;
            txtConference.Text = attendee1.ConferenceName;
            cmbReg.Text = attendee1.RegType;
            checkPaid.IsChecked = attendee1.Paid;
            checkPresenter.IsChecked = attendee1.Presenter;
            txtTitle.Text = attendee1.PaperTitle;
        }

        private void btnInvoice_Click(object sender, RoutedEventArgs e)     // Encompasses the code executed when the user presses 'Invoice' on the GUI
        {

            Invoice inv = new Invoice(ref attendee1);                       // Creating and opening a new window object for Invoice
            inv.Show();
        }

        private void btnCertificate_Click(object sender, RoutedEventArgs e) // Encompasses the code executed when the user presses 'Certificate' on the GUI
        {
            Certificate cert = new Certificate(ref attendee1);              // Creating and opening a new window object for Certificate
            cert.Show();
        }

        private void checkPaid_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void checkPresenter_Checked(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
