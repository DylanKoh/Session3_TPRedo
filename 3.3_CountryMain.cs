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
    public partial class CountryMain : Form
    {
        User _user;
        public CountryMain(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnConfirmArrival_Click(object sender, EventArgs e)
        {
            Hide();
            (new ConfirmArrival(_user)).ShowDialog();
            Close();
        }

        private void btnHotelBooking_Click(object sender, EventArgs e)
        {
            Hide();
            (new HotelSelection(_user)).ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            (new Update(_user)).ShowDialog();
            Close();
        }
    }
}
