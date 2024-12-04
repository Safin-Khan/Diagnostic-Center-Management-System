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
    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Validation(string UserID, string Password)
        {
            try
            {
                string sql = "Select * from Users where UserId = '" + UserID + "' and Password = '" + Password + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string dbUserID = Convert.ToString(ds.Tables[0].Rows[0]["UserID"]);
                    String dbPassword = Convert.ToString(ds.Tables[0].Rows[0]["Password"]);

                    if (dbUserID.Equals(UserID) && dbPassword.Equals(Password))
                    {
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Role"]) == "Admin")
                        {
                            this.Visible = false;
                            AdminDashboard ad = new AdminDashboard(UserID.ToString());
                            ad.Show();

                        }
                        else if (Convert.ToString(ds.Tables[0].Rows[0]["Role"]) == "Receptionist")
                        {
                            this.Visible = false;
                            ReceptionistDashboard rd = new ReceptionistDashboard(UserID.ToString());
                            rd.Show();

                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect User Id or Password, Please try again", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Unexpected Error Occured");
            }

         }
 

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Validation(this.UserIdTxtBox.Text, this.PasswordTxtBox.Text);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
