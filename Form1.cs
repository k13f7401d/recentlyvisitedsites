using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecentlyVisitedSites
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set tooltips for link labels.
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(lnkLabel1, "Excellent search engine!");

            System.Windows.Forms.ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
            toolTip2.SetToolTip(lnkLabel2, "Social Media Site that rose to prominence in 2008.");

            System.Windows.Forms.ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
            toolTip3.SetToolTip(lnkLabel3, "Encyclopedia. Trust at your own risk!");
        }

       
        //Close the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Please ignore.
        private void lnkOne_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        // Opens default browser when link is clicked.
        private void lnkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://google.com");
        }


        // Opens browser when Link 2 is clicked.
        private void lnkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://facebook.com");
        }


        // Open browser when Link 3 is clicked.
        private void lnkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://wikipedia.org");
        }

        // Please ignore.
        private void lblInfo_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
