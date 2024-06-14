using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaUniformes.Views
{
    public partial class CustomerCM : Form
    {
        public CustomerCM()
        {
            InitializeComponent();
        }
        private string nombre = "";

        private string phone = "";

        public string Nombre
        {
            get { return nombre; }
        }

        public string Phone
        {
            get { return phone; }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text.Length < 10)
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                nombre = txtName.Text;
                phone = txtPhone.Text.Replace("-", "");
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameBtn(bool boton, string texto = "", string phone = "")
        {
            if (boton)
            {
                btnCM.Text = "&Modificar";
                txtName.Text = texto;
                txtPhone.Text = phone;
            }
        }
    }
}
