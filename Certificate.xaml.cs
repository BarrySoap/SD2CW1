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
 * Class Purpose: This window will represent an certificate of the attendee,
 *                showing their name, conference name and possibly their
 *                paper title.
 * Date last modified: 22/10/2016
 */

namespace CW1
{
    public partial class Certificate : Window
    {
        public Certificate(ref Attendee attendee1)
        {
            InitializeComponent();

            if (attendee1.Presenter == true)
            {
                txtCertificate.Text = ("This is to certify that " + attendee1.FirstName + " " + attendee1.SecondName + " attended " + attendee1.ConferenceName + " and presented a paper entitled " + attendee1.PaperTitle + ".");
            }
            else
            {
                txtCertificate.Text = ("This is to certify that " + attendee1.FirstName + " " + attendee1.SecondName + " attended " + attendee1.ConferenceName + ".");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
