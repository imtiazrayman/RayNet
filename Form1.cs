using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // takes bits and peices  yout time line will be in days, the groups will meet in every single day. Will meet for 5 mins, this is will be called a stand up meeting, the stand up meeting will soend for about 5 mineutesd
        // in the meeting you take the thing in small bites and get it doe incrementally, meet up and set up to get done.
        // deliverable, th epackage will get bigger.

            // one page summery 
            // no more than 15 slides in the powerpoint
            // flow chart.
        private void btnGo_Click(object sender, EventArgs e)
        {
            //   http://www.google.com
            if (txtAddressbar.Text.ToString().Contains("http://www."))
            {
                webBrowser1.Navigate(new Uri(txtAddressbar.Text));
            }
            else if (string.IsNullOrEmpty(txtAddressbar.Text ))
            {
                MessageBox.Show("Must put a search query", "Empty Url", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            else if (!(txtAddressbar.Text.ToString().Contains("http://www.") && txtAddressbar.Text.ToString().Contains(".com")))
            {
                string searchQuery = txtAddressbar.Text.ToString();
                string appendedSearchQuery = "http://www." + searchQuery + ".com";
                webBrowser1.Navigate(new Uri(appendedSearchQuery));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            //webBrowser1.GoHome();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {

            webBrowser1.GoForward();
        }

        private void txtAddressbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
