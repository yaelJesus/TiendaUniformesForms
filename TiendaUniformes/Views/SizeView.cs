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
    public partial class SizeView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public SizeView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("Size", "GetSizes?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idS;
                    row.Cells[1].Value = item.size1;
                    row.Cells[2].Value = item.price;
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
                SizeCM nuevo = new SizeCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel || string.IsNullOrEmpty(nuevo.Talla.ToString()))
                    return;

                Models.Size size = new Models.Size()
                {
                    size1 = nuevo.Talla,
                    price = nuevo.Presio,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(size);

                dynamic respuesta = dBApi.Post("Size", "CreateSize", json);

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
                SizeCM nuevo = new SizeCM();
                var talla = dgList.CurrentRow.Cells[1].Value.ToString();
                var presio = dgList.CurrentRow.Cells[2].Value.ToString();
                nuevo.NameBtn(true, talla!, presio!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Models.Size size = new Models.Size
                {
                    idS = int.Parse(a!),
                    size1 = nuevo.Talla,
                    price = nuevo.Presio,
                    modifyUser = user
                };

                string json = JsonConvert.SerializeObject(size);

                dynamic respuesta = dBApi.Post("Size", "UpdateSize", json);

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
                if (MessageBox.Show("¿Estas seguro que deseas eliminar la talla " + x + "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Models.Size size = new Models.Size
                {
                    idS = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(size);

                dynamic respuesta = dBApi.Post("Size", "DeleteSize?idS=" + a, json);

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
