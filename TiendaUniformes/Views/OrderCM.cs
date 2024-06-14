using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TiendaUniformes.Views
{
    public partial class OrderCM : Form
    {
        public OrderCM()
        {
            InitializeComponent();
            txtDateOrder.Text = dateOrder.ToString("yyyy/MM/dd");
            txtDeadLine.Text = deadLine.ToString("yyyy/MM/dd");
        }
        private DateOnly dateOrder = DateOnly.FromDateTime(DateTime.Now);

        private DateOnly deadLine = DateOnly.FromDateTime(DateTime.Now.AddDays(1));

        private int idC = 0;

        private int total = 0;

        public DateOnly DateOrder
        {
            get { return dateOrder; }
        }

        public DateOnly DeadLine
        {
            get { return deadLine; }
        }

        public int IdC
        {
            get { return idC; }
        }

        public int Total
        {
            get { return total; }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDateOrder.Text) || string.IsNullOrEmpty(txtDeadLine.Text) || string.IsNullOrEmpty(txtIdC.Text) || string.IsNullOrEmpty(txtTotal.Text))
                MessageBox.Show("Por favor llene los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DateTime dt = DateTime.Parse(txtDateOrder.Text);
                dateOrder = DateOnly.FromDateTime(dt);
                dt = DateTime.Parse(txtDeadLine.Text);
                deadLine = DateOnly.FromDateTime(dt);
                idC = int.Parse(txtIdC.Text);
                total = int.Parse(txtTotal.Text);
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameBtn(bool boton, string dateO = "", string deadLine = "", string idc = "", string total = "")
        {
            if (boton)
            {
                btnCM.Text = "&Modificar";
                txtDateOrder.Text = dateO;
                txtDeadLine.Text = deadLine;
                txtIdC.Text = idc;
                txtTotal.Text = total;
            }
        }
    }
}
