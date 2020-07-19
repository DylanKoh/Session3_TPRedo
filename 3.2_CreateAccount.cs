using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3_TPRedo
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadCB();
        }

        private void LoadCB()
        {
            using (var context = new Session3Entities())
            {
                var countries = new List<string>()
                {
                    "Brunei", "Cambodia", "Indonesia", "Laos", "Malaysia", "Myanmar", "Philippines", "Singapore", "Thailand", "Vietnam"
                };

                var getRegistered = (from x in context.Users
                                     where x.userTypeIdFK == 2
                                     select x.countryName).ToList();
                foreach (var item in getRegistered)
                {
                    countries.Remove(item);
                }
                cbCountries.Items.AddRange(countries.ToArray());
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbCountries.SelectedItem == null || string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtRePassword.Text))
            {
                MessageBox.Show("Please ensure the field(s) are not empty!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRePassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserID.Text.Length < 8)
            {
                MessageBox.Show("User ID must be at least 8 characters long!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtUserID.Text, "[a-zA-Z]+[0-9]+"))
            {
                MessageBox.Show("User ID must contain 1 upper and lower case with at least 1 numeric!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var context = new Session3Entities())
                {
                    var checkID = (from x in context.Users
                                   where x.userId == txtUserID.Text
                                   select x).FirstOrDefault();
                    if (checkID != null)
                    {
                        MessageBox.Show("User ID is not available! Please use another User ID", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var newUser = new User() { userId = txtUserID.Text, countryName = cbCountries.SelectedItem.ToString(), passwd = txtRePassword.Text, userTypeIdFK = 2 };
                        context.Users.Add(newUser);
                        context.SaveChanges();
                        MessageBox.Show("Account created successfully!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        (new Login()).ShowDialog();
                        Close();
                    }
                }

            }

        }
    }
}
