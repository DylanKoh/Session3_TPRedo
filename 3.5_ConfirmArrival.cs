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
    public partial class ConfirmArrival : Form
    {
        User _user;
        public ConfirmArrival(User user)
        {
            InitializeComponent();
            _user = user;
        }



        private void LoadTimings()
        {
            dataGridView1.Rows.Clear();
            var timings = new List<string>() { "9am", "10am", "11am", "12pm",
            "1pm", "2pm", "3pm", "4pm"};
            dataGridView1.Rows.Add(timings.ToArray());
        }

        private void rbtn22July_CheckedChanged(object sender, EventArgs e)
        {
            LoadTimings();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn cell in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "10am")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }
                    else if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "1pm")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }
                    else if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "2pm")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }

                }
            }
        }

        private void rbtn23July_CheckedChanged(object sender, EventArgs e)
        {
            LoadTimings();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn cell in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "9am")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }
                    else if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "12pm")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }
                    else if (dataGridView1.Rows[row.Index].Cells[cell.Index].Value.ToString() == "4pm")
                    {
                        dataGridView1.Rows[row.Index].Cells[cell.Index].Style.BackColor = Color.Black;
                    }

                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (var context = new Session3Entities())
            {
                if (rbtn22July.Checked)
                {
                    if (dataGridView1.CurrentCell.Style.BackColor == Color.Black)
                    {
                        MessageBox.Show("Timing is not available for selected date!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var getTiming = dataGridView1.CurrentCell.Value.ToString();
                        var getArrivalDetails = (from x in context.Arrivals
                                                 where x.userIdFK == _user.userId
                                                 select x).FirstOrDefault();
                        if (getArrivalDetails == null)
                        {
                            var newArrival = new Arrival()
                            {
                                arrivalDate = DateTime.Parse("22/07/2020"),
                                arrivalTime = getTiming,
                                number19seat = Int32.Parse(lbl19Seater.Text),
                                number42seat = Int32.Parse(lbl42Seater.Text),
                                numberCars = Int32.Parse(lblCar.Text),
                                userIdFK = _user.userId,
                                numberHead = Convert.ToInt32(nudHead.Value),
                                numberDelegate = Convert.ToInt32(nudDelegates.Value),
                                numberCompetitors = Convert.ToInt32(nudCompetitors.Value)
                            };
                            context.Arrivals.Add(newArrival);
                            context.SaveChanges();
                            MessageBox.Show("Arrival confirmed!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            (new CountryMain(_user)).ShowDialog();
                            Close();
                        }
                        else
                        {
                            getArrivalDetails.arrivalDate = DateTime.Parse("22/07/2020");
                            getArrivalDetails.arrivalTime = getTiming;
                            getArrivalDetails.number19seat = Int32.Parse(lbl19Seater.Text);
                            getArrivalDetails.number42seat = Int32.Parse(lbl42Seater.Text);
                            getArrivalDetails.numberCars = Int32.Parse(lblCar.Text);
                            getArrivalDetails.numberHead = Convert.ToInt32(nudHead.Value);
                            getArrivalDetails.numberDelegate = Convert.ToInt32(nudDelegates.Value);
                            getArrivalDetails.numberCompetitors = Convert.ToInt32(nudCompetitors.Value);
                            context.SaveChanges();
                            MessageBox.Show("Arrival updated!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            (new CountryMain(_user)).ShowDialog();
                            Close();
                        }
                    }
                    

                }
                else if (rbtn23July.Checked)
                {
                    if (dataGridView1.CurrentCell.Style.BackColor == Color.Black)
                    {
                        MessageBox.Show("Timing is not available for selected date!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var getTiming = dataGridView1.CurrentCell.Value.ToString();
                        var getArrivalDetails = (from x in context.Arrivals
                                                 where x.userIdFK == _user.userId
                                                 select x).FirstOrDefault();
                        if (getArrivalDetails == null)
                        {
                            var newArrival = new Arrival()
                            {
                                arrivalDate = DateTime.Parse("23/07/2020"),
                                arrivalTime = getTiming,
                                number19seat = Int32.Parse(lbl19Seater.Text),
                                number42seat = Int32.Parse(lbl42Seater.Text),
                                numberCars = Int32.Parse(lblCar.Text),
                                userIdFK = _user.userId,
                                numberHead = Convert.ToInt32(nudHead.Value),
                                numberDelegate = Convert.ToInt32(nudDelegates.Value),
                                numberCompetitors = Convert.ToInt32(nudCompetitors.Value)
                            };
                            context.Arrivals.Add(newArrival);
                            context.SaveChanges();
                            MessageBox.Show("Arrival confirmed!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            (new CountryMain(_user)).ShowDialog();
                            Close();
                        }
                        else
                        {
                            getArrivalDetails.arrivalDate = DateTime.Parse("23/07/2020");
                            getArrivalDetails.arrivalTime = getTiming;
                            getArrivalDetails.number19seat = Int32.Parse(lbl19Seater.Text);
                            getArrivalDetails.number42seat = Int32.Parse(lbl42Seater.Text);
                            getArrivalDetails.numberCars = Int32.Parse(lblCar.Text);
                            getArrivalDetails.numberHead = Convert.ToInt32(nudHead.Value);
                            getArrivalDetails.numberDelegate = Convert.ToInt32(nudDelegates.Value);
                            getArrivalDetails.numberCompetitors = Convert.ToInt32(nudCompetitors.Value);
                            context.SaveChanges();
                            MessageBox.Show("Arrival updated!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            (new CountryMain(_user)).ShowDialog();
                            Close();
                        }
                    }
                }
            }
            
        }

        private void nudHead_ValueChanged(object sender, EventArgs e)
        {
            if (nudHead.Value == 1)
            {
                lblCar.Text = "1";
            }
            else
            {
                lblCar.Text = "0";
            }
        }

        private void nudDelegates_ValueChanged(object sender, EventArgs e)
        {
            lbl19Seater.Text = "0";
            lbl42Seater.Text = "0";
            int getTotal = Convert.ToInt32(nudDelegates.Value + nudCompetitors.Value);
            int getReminder42 = getTotal % 42;
            if (getTotal > 38 && getTotal <= 42)
            {
                lbl42Seater.Text = "1";
            }
            else if (getTotal > 19 && getTotal <= 38)
            {
                lbl19Seater.Text = "2";
            }
            else if (getTotal <= 19)
            {
                lbl19Seater.Text = "1";
            }
            else
            {
                if (getReminder42 == 0)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                }
                else if (getReminder42 <= 19)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                    lbl19Seater.Text = (Int32.Parse(lbl19Seater.Text) + 1).ToString();
                }
                else if (getReminder42 > 19 && getReminder42 <= 38)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                    lbl19Seater.Text = (Int32.Parse(lbl19Seater.Text) + 2).ToString();
                }
                else if (getReminder42 > 38)
                {
                    lbl42Seater.Text = ((getTotal / 42) + 1).ToString();
                }
            }
            
        }

        private void nudCompetitors_ValueChanged(object sender, EventArgs e)
        {
            lbl19Seater.Text = "0";
            lbl42Seater.Text = "0";
            int getTotal = Convert.ToInt32(nudDelegates.Value + nudCompetitors.Value);
            int getReminder42 = getTotal % 42;
            if (getTotal > 38 && getTotal <= 42)
            {
                lbl42Seater.Text = "1";
            }
            else if (getTotal > 19 && getTotal <= 38)
            {
                lbl19Seater.Text = "2";
            }
            else if (getTotal <= 19)
            {
                lbl19Seater.Text = "1";
            }
            else
            {
                if (getReminder42 == 0)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                }
                else if (getReminder42 <= 19)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                    lbl19Seater.Text = (Int32.Parse(lbl19Seater.Text) + 1).ToString();
                }
                else if (getReminder42 > 19 && getReminder42 <= 38)
                {
                    lbl42Seater.Text = (getTotal / 42).ToString();
                    lbl19Seater.Text = (Int32.Parse(lbl19Seater.Text) + 2).ToString();
                }
                else if (getReminder42 > 38)
                {
                    lbl42Seater.Text = ((getTotal / 42) + 1).ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new CountryMain(_user)).ShowDialog();
            Close();
        }
    }
}
