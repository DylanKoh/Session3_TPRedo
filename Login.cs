using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3_TPRedo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please ensure the field(s) are not empty!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var context = new Session3Entities())
                {
                    var getUser = (from x in context.Users
                                   where x.userId == txtUserID.Text
                                   select x).FirstOrDefault();
                    if (getUser == null)
                    {
                        MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (getUser.passwd != txtPassword.Text)
                        {
                            MessageBox.Show("Password is incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Welcome {getUser.countryName}!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (getUser.userTypeIdFK == 1)
                            {

                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
