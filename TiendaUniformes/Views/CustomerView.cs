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
    public partial class CustomerView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public CustomerView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("Customer", "GetCustomer?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idC;
                    row.Cells[1].Value = item.name;
                    row.Cells[2].Value = item.phone;
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
                CustomerCM nuevo = new CustomerCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel || string.IsNullOrEmpty(nuevo.Nombre))
                    return;

                Customer customer = new Customer
                {
                    name = nuevo.Nombre,
                    phone = nuevo.Phone,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(customer);

                dynamic respuesta = dBApi.Post("Customer", "CreateCustomer", json);

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
                CustomerCM nuevo = new CustomerCM();
                var nombre = dgList.CurrentRow.Cells[1].Value.ToString();
                var phone = dgList.CurrentRow.Cells[2].Value.ToString();
                nuevo.NameBtn(true, nombre!, phone!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Customer customer = new Customer
                {
                    idC = int.Parse(a!),
                    name = nuevo.Nombre,
                    phone = nuevo.Phone,
                    modifyUser = user
                };

                string json = JsonConvert.SerializeObject(customer);

                dynamic respuesta = dBApi.Post("Customer", "UpdateCustomer", json);

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

                Customer customer = new Customer
                {
                    idC = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(customer);

                dynamic respuesta = dBApi.Post("Customer", "DeleteCustomer?idC=" + a, json);

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
