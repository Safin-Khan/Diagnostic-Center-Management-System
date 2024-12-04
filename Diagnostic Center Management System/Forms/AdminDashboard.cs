using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Diagnostic_Center_Management_System
{
    public partial class AdminDashboard : Form
    {
        string userId;
        public AdminDashboard(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

    


        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoggedOut lo = new LoggedOut();
            lo.Show();
            this.Hide();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            CreateTest ct = new CreateTest();
            this.adminPanel.Controls.Add(ct);

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            EditTest et = new EditTest();
            this.adminPanel.Controls.Add(et);

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AddReceptionist ar = new AddReceptionist();
            this.adminPanel.Controls.Add(ar);

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ManageReceptionists mr = new ManageReceptionists();
            this.adminPanel.Controls.Add(mr);

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            UpdatePassword up = new UpdatePassword(this.userId);
            this.adminPanel.Controls.Add(up);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            this.adminPanel.Controls.Add(panel5);
        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            this.adminPanel.Controls.Add(panel5);

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AdminViewSalesReport_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AdminSalesReport asr = new AdminSalesReport();
            this.adminPanel.Controls.Add(asr);

        }

        private void ViewInvoices_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewInvoices vi = new ViewInvoices();
            this.adminPanel.Controls.Add(vi);
        }
    }
}
