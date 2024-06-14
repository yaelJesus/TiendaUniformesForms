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
    public partial class InventoryCM : Form
    {
        public InventoryCM()
        {
            InitializeComponent();
        }

        private int idSc = 0;

        private int idG = 0;

        private int qty = 0;

        public int IdSc
        {
            get { return idSc; }
        }

        public int IdG
        {
            get { return idG; }
        }

        public int Qty
        {
            get { return qty; }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdSc.Text) || string.IsNullOrEmpty(txtIdG.Text) || string.IsNullOrEmpty(txtQty.Text))
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                idSc = int.Parse(txtIdSc.Text);
                idG = int.Parse(txtIdG.Text);
                qty = int.Parse(txtQty.Text);
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameBtn(bool boton, string idsc = "", string idg = "", string qty = "")
        {
            if (boton)
            {
                btnCM.Text = "&Modificar";
                txtIdSc.Text = idsc;
                txtIdG.Text = idg;
                txtQty.Text = qty;
            }
        }
    }
}
