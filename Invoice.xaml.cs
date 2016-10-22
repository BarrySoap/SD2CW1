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
using System.Windows.Shapes;

/* Author: Glenn Wilkie-Sullivan (40208762)
 * Class Purpose: This window will represent an invoice, displaying the name,
 *                institiution, conference and cost of the attendee.
 * Date last modified: 22/10/2016
 */

namespace CW1
{
    public partial class Invoice : Window
    {
        public Invoice(ref Attendee attendee1)
        {
            InitializeComponent();

            txtInvoice.Text = ("Name: " + attendee1.FirstName + " " + attendee1.SecondName + "\n" + 
                               "Institution: " + attendee1.InstitutionName + "\n" +
                               "Conference Name: " + attendee1.ConferenceName + "\n" +
                               "Price: " + attendee1.getCost());
        }
    }
}
