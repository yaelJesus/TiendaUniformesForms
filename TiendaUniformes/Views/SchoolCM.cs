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
    public partial class SchoolCM : Form
    {
        public SchoolCM()
        {
            InitializeComponent();
        }

        private string nombre = "";

        public string Nombre
        {
            get { return nombre; }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nombre = txtName.Text;
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameBtn(bool boton, string texto = "")
        {
            if (boton)
            {
                btnCM.Text = "&Modificar";
                txtName.Text = texto;
            }
        }
    }
}
