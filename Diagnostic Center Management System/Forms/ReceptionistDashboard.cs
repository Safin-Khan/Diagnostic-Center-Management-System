using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center_Management_System
{
    public partial class ReceptionistDashboard : Form
    {
        string receptionistID;
        public ReceptionistDashboard()
        {
            InitializeComponent();
        }
        public ReceptionistDashboard(string receptionistId)
        {
            this.receptionistID = receptionistId;
            InitializeComponent();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoggedOut lo = new LoggedOut();
            lo.Show();
            this.Hide();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.receptionistPanel.Controls.Clear();
            UpdatePassword up1 = new UpdatePassword(this.receptionistID);
            this.receptionistPanel.Controls.Add(up1);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.receptionistPanel.Controls.Clear();
            this.receptionistPanel.Controls.Add(panel5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.receptionistPanel.Controls.Clear();
            this.receptionistPanel.Controls.Add(panel5);
        }

        private void ReceptionistDashboard_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;    
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.receptionistPanel.Controls.Clear();
            CreateInvoice ci = new CreateInvoice(receptionistID); 
            this.receptionistPanel.Controls.Add(ci);
        }

        private void ReceptionistDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ViewReceptionistSalesReport_Click(object sender, EventArgs e)
        {
            this.receptionistPanel.Controls.Clear();
            ReceptionistSalesReport rsr = new ReceptionistSalesReport(receptionistID);
            this.receptionistPanel.Controls.Add(rsr);
        }
    }
}
