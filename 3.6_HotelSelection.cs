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
    public partial class HotelSelection : Form
    {
        User _user;
        public HotelSelection(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnRitzCarlton_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Ritz-Carlton")).ShowDialog();
        }

        private void btnPanPacific_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Pan Pacific Hotel")).ShowDialog();
        }

        private void btnCharlton_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Charlton Hotel")).ShowDialog();
        }

        private void btnHotelGrandPacific_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Hotel Grand Pacific")).ShowDialog();
        }

        private void btnIntercontinental_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Intercontinental Singapore")).ShowDialog();
        }

        private void btnHotelRoyalQueens_Click(object sender, EventArgs e)
        {
            (new HotelBooking(_user, "Hotel Royal Queens")).ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new CountryMain(_user)).ShowDialog();
            Close();
        }
    }
}
