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
 * Date last modified: 10/10/2016
 */

namespace CW1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            Attendee attendee1 = new Attendee();                            // Creating the attendee object

            double tempnum;
            attendee1.FirstName = txtName1.Text;
            attendee1.SecondName = txtName2.Text;
            attendee1.InstitutionName = txtInstitution.Text;
            attendee1.ConferenceName = txtConference.Text;
            attendee1.PaperTitle = txtTitle.Text;

            if (Double.TryParse(txtAttendee.Text, out tempnum))
            {
                attendee1.AttendeeRef = Double.Parse(txtAttendee.Text);     // This block of code will test the contents of the attendeeRef text box to
            } else                                                          // check if it is either: not blank/not a string. If the contents of the box is a valid
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName1.Text = "";
            txtName2.Text = "";
            txtAttendee.Text = "";
            txtInstitution.Text = "";
            txtConference.Text = "";
            checkPaid.IsChecked = false;
            checkPresenter.IsChecked = false;
            cmbReg.SelectedIndex = -1;
            txtTitle.Text = "";
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCertificate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void checkPaid_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void checkPresenter_Checked(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
