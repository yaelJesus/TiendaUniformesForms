using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaUniformes.School;

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

        }

        private void btnSchools_Click(object sender, EventArgs e)
        {
            SchoolView view = new SchoolView(user);
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }
    }
}
