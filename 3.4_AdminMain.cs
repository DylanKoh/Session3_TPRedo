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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnArrivalSummary_Click(object sender, EventArgs e)
        {
            Hide();
            (new ArrivalSummary()).ShowDialog();
            Close();
        }

        private void btnHotelSummary_Click(object sender, EventArgs e)
        {
            Hide();
            (new HotelSummary()).ShowDialog();
            Close();
        }

        private void btnGuestsSummary_Click(object sender, EventArgs e)
        {
            Hide();
            (new GuestsSummary()).ShowDialog();
            Close();
        }
    }
}
