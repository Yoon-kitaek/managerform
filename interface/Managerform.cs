using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using data;
using Managerform;

namespace ManagerForm
{

    public partial class Managerform : DevExpress.XtraEditors.XtraForm
    {
        public Managerform()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            List<Seat> seats = DataRepository.Seat.GetAll();
            seatBindingSource.DataSource = seats;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Seat seat = seatBindingSource.Current as Seat;

            if (seat == null)
                return;

            MessageBox.Show($"{seat.SeatID} / {seat.CustomerID}");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Seat seat = seatBindingSource.Current as Seat;

            if (seat == null)
                return;

            lblSeat.Text = seat.SeatID.ToString();
            if (seat.CustomerID != null)
            {
                Customer customer = DataRepository.Customer.Get(seat.CustomerID.Value);
                lblName.Text = customer.Name;
                lblId.Text = customer.LoginID.ToString();
                lblRemainingTime.Text = customer.RemainingTime.ToString();
            }
        }

        private void btnAddtime_Click(object sender, EventArgs e)
        {
            AddTimeform addtimeform = new AddTimeform();
            addtimeform.Show();
            
        }

        private void Managerform_Load(object sender, EventArgs e)
        {
            ManagerLoginform managerloginform = new ManagerLoginform();
            managerloginform.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DeleteCustomerform deletecustomerform = new DeleteCustomerform();
            deletecustomerform.Show();
        }
    }
}