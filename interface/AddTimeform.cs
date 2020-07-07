using data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class AddTimeform : Form
    {
        public AddTimeform()
        {
            InitializeComponent();
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddTimeform_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = DataRepository.Customer.GetAll();
            List<Product> products = DataRepository.Product.GetAll().FindAll(x => x.CodeID == 101);
            productBindingSource.DataSource = products;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
