using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace TiendaUniformes.Views
{
    public partial class SizeCM : Form
    {
        public SizeCM()
        {
            InitializeComponent();
        }
        private int talla = 0;

        private int presio = 0;

        public int Talla
        {
            get { return talla; }
        }

        public int Presio
        {
            get { return presio; }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTalla.Text) || string.IsNullOrEmpty(txtPresio.Text))
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                talla = int.Parse(txtTalla.Text);
                presio = int.Parse(txtPresio.Text);
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
                txtTalla.Text = texto;
                txtPresio.Text = phone;
            }
        }
    }
}
