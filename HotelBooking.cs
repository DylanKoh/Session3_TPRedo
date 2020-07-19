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
    public partial class HotelBooking : Form
    {
        User _user;
        string _hotel;
        DateTime _arrivalDate;
        public HotelBooking(User user, string Hotel)
        {
            InitializeComponent();
            _user = user;
            _hotel = Hotel;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HotelBooking_Load(object sender, EventArgs e)
        {
            lblHotelName.Text = _hotel;
            using (var context = new Session3Entities())
            {
                var getArrival = (from x in context.Arrivals
                                  where x.userIdFK == _user.userId
                                  select x).FirstOrDefault();
                lblCompetitors.Text = getArrival.numberCompetitors.ToString();
                lblDelegates.Text = getArrival.numberDelegate.ToString();
                LoadDGV();
            }
        }

        private void LoadDGV()
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session3Entities())
            {
                var getArrivalDate = (from x in context.Arrivals
                                      where x.userIdFK == _user.userId
                                      select x.arrivalDate).FirstOrDefault();
                _arrivalDate = getArrivalDate;
                var getHotelDetails = (from x in context.Hotels
                                       where x.hotelName == _hotel
                                       select x).FirstOrDefault();
                var checkCompetitorRemainder = Int32.Parse(lblCompetitors.Text) % 2;
                if (checkCompetitorRemainder == 1)
                {
                    var singleRow = new List<string>() { "Single", getHotelDetails.singleRate.ToString(),
                (getHotelDetails.numSingleRoomsTotal - getHotelDetails.numSingleRoomsBooked).ToString(), (Int32.Parse(lblDelegates.Text)+1).ToString(),
                    ((Int32.Parse(lblDelegates.Text)+1) * (DateTime.Parse("30/07/2020")-getArrivalDate).Days * getHotelDetails.singleRate).ToString()};

                    var doubleRow = new List<string>() { "Double", getHotelDetails.doubleRate.ToString(),
                (getHotelDetails.numDoubleRoomsTotal - getHotelDetails.numDoubleRoomsBooked).ToString(), (Int32.Parse(lblCompetitors.Text)/2).ToString(),
                    ((Int32.Parse(lblCompetitors.Text)/2) * (DateTime.Parse("30/07/2020")-getArrivalDate).Days * getHotelDetails.doubleRate).ToString()};
                    dataGridView1.Rows.Add(singleRow.ToArray());
                    dataGridView1.Rows.Add(doubleRow.ToArray());
                }
                else
                {
                    var singleRow = new List<string>() { "Single", getHotelDetails.singleRate.ToString(),
                (getHotelDetails.numSingleRoomsTotal - getHotelDetails.numSingleRoomsBooked).ToString(), (Int32.Parse(lblDelegates.Text)).ToString(),
                    ((Int32.Parse(lblDelegates.Text)) * (DateTime.Parse("30/07/2020")-getArrivalDate).Days * getHotelDetails.singleRate).ToString()};

                    var doubleRow = new List<string>() { "Double", getHotelDetails.doubleRate.ToString(),
                (getHotelDetails.numDoubleRoomsTotal - getHotelDetails.numDoubleRoomsBooked).ToString(), (Int32.Parse(lblCompetitors.Text)/2).ToString(),
                    ((Int32.Parse(lblCompetitors.Text)/2) * (DateTime.Parse("30/07/2020")-getArrivalDate).Days * getHotelDetails.doubleRate).ToString()};
                    dataGridView1.Rows.Add(singleRow.ToArray());
                    dataGridView1.Rows.Add(doubleRow.ToArray());
                }

            }
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var getRoomType = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (getRoomType == "Double")
                {
                    if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < Int32.Parse(lblCompetitors.Text) / 2)
                    {
                        MessageBox.Show("Rooms are not enough to cater to competitors");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) * (DateTime.Parse("30/07/2020") - _arrivalDate).Days * Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    }
                }
                if (getRoomType == "Single")
                {
                    if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < Int32.Parse(lblDelegates.Text))
                    {
                        MessageBox.Show("Rooms are not enough to cater to Delegates");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) * (DateTime.Parse("30/07/2020") - _arrivalDate).Days * Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    }
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            using(var context = new Session3Entities())
            {
                var getHotelID = (from x in context.Hotels
                                  where x.hotelName == _hotel
                                  select x.hotelId).FirstOrDefault();
                var newBooking = new Hotel_Booking()
                {
                    userIdFK = _user.userId,
                    hotelIdFK = getHotelID,
                    numDoubleRoomsRequired = Convert.ToInt32(dataGridView1.Rows[1].Cells[3].Value),
                    numSingleRoomsRequired = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value)
                };
                context.Hotel_Booking.Add(newBooking);
                context.SaveChanges();
                MessageBox.Show("Booking successful!");
                Close();
            }
        }
    }
}
