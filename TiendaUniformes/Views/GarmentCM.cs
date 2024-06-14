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

namespace TiendaUniformes.Views
{
    public partial class GarmentCM : Form
    {
        public GarmentCM()
        {
            InitializeComponent();
        }
        private string type = "";

        private string desc = "";

        private int idS = 0;

        private int idSc = 0;

        public string Type
        {
            get { return type; }
        }

        public string Desc
        {
            get { return desc; }
        }
        public int IdS
        {
            get { return idS; }
        }

        public int IdSc
        {
            get { return idSc; }
        }
        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtType.Text) || string.IsNullOrEmpty(txtIdS.Text) || string.IsNullOrEmpty(txtIdSc.Text))
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                type = txtType.Text;
                desc = txtDesc.Text;
                idS = int.Parse(txtIdS.Text);
                idSc = int.Parse(txtIdSc.Text);
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameBtn(bool boton, string type = "", string ids = "", string idsc = "", string desc = "")
        {
            if (boton)
            {
                btnCM.Text = "&Modificar";
                txtType.Text = type;
                txtIdS.Text = ids;
                txtIdSc.Text = idsc;
                txtDesc.Text = desc;
            }
        }
    }
}
