using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaUniformes.Views;

namespace TiendaUniformes
{
    public partial class Menu : Form
    {
        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login view = new Login();
            view.Show();
            Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerView view = new CustomerView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnSchools_Click(object sender, EventArgs e)
        {
            SchoolView view = new SchoolView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnSizes_Click(object sender, EventArgs e)
        {
            SizeView view = new SizeView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnGarments_Click(object sender, EventArgs e)
        {
            GarmentView view = new GarmentView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryView view = new InventoryView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderView view = new OrderView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }
    }
}
