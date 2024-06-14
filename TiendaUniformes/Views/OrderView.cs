using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaUniformes.ApiRest;
using TiendaUniformes.Models;

namespace TiendaUniformes.Views
{
    public partial class OrderView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public OrderView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("Order", "GetOrder?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idO;
                    row.Cells[1].Value = item.dateOrder;
                    row.Cells[2].Value = item.deadLine;
                    row.Cells[3].Value = item.idC;
                    row.Cells[4].Value = item.totalPrice;
                    dgList.Rows.Add(row);
                }
            }
            catch (Exception)
            { }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                OrderCM nuevo = new OrderCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel || string.IsNullOrEmpty(nuevo.IdC.ToString()))
                    return;

                Order order = new Order
                {
                    dateOrder = nuevo.DateOrder,
                    deadLine = nuevo.DeadLine,
                    idC = nuevo.IdC,
                    totalPrice = nuevo.Total,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(order);

                dynamic respuesta = dBApi.Post("Order", "CreateOrder", json);

                if (respuesta.status == 200)
                {
                    Get();
                }
                else
                {
                    foreach (var item in respuesta.errors)
                    {
                        MessageBox.Show(item.ToString(), "Errores");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                OrderCM nuevo = new OrderCM();
                var dateO = dgList.CurrentRow.Cells[1].Value.ToString();
                var deadLine = dgList.CurrentRow.Cells[2].Value.ToString();
                var idc = dgList.CurrentRow.Cells[3].Value.ToString();
                var total = dgList.CurrentRow.Cells[4].Value.ToString();
                nuevo.NameBtn(true, dateO!, deadLine!, idc!, total!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Order order = new Order
                {
                    idO = int.Parse(a!),
                    dateOrder = nuevo.DateOrder,
                    deadLine = nuevo.DeadLine,
                    idC = nuevo.IdC,
                    totalPrice = nuevo.Total,
                    modifyUser = user
                };

                string json = JsonConvert.SerializeObject(order);

                dynamic respuesta = dBApi.Post("Order", "UpdateOrder", json);

                if (respuesta.status == 200)
                {
                    Get();
                }
                else
                {
                    foreach (var item in respuesta.errors)
                    {
                        MessageBox.Show(item.ToString(), "Errores");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = dgList.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("¿Estas seguro que deseas eliminar a " + x + "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Order order = new Order
                {
                    idO = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(order);

                dynamic respuesta = dBApi.Post("Order", "DeleteOrder?idO=" + a, json);

                if (respuesta.status == 200)
                {
                    Get();
                }
                else
                {
                    foreach (var item in respuesta.errors)
                    {
                        MessageBox.Show(item.ToString(), "Errores");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
