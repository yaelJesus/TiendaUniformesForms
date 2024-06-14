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
    public partial class GarmentView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public GarmentView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("Garment", "GetGarment?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idG;
                    row.Cells[1].Value = item.type;
                    row.Cells[2].Value = item.desctiption;
                    row.Cells[3].Value = item.idS;
                    row.Cells[4].Value = item.idSc;
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
                GarmentCM nuevo = new GarmentCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel || string.IsNullOrEmpty(nuevo.Type))
                    return;

                Garment garment = new Garment
                {
                    type = nuevo.Type,
                    desctiption = nuevo.Desc,
                    idS = nuevo.IdS,
                    idSc = nuevo.IdSc,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(garment);

                dynamic respuesta = dBApi.Post("Garment", "CreateGarment", json);

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
                GarmentCM nuevo = new GarmentCM();
                var tipo = dgList.CurrentRow.Cells[1].Value.ToString();
                var desc = dgList.CurrentRow.Cells[2].Value.ToString();
                var ids = dgList.CurrentRow.Cells[3].Value.ToString();
                var idsc = dgList.CurrentRow.Cells[4].Value.ToString();
                nuevo.NameBtn(true, tipo!, ids!, idsc!, desc!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Garment customer = new Garment
                {
                    idG = int.Parse(a!),
                    type = nuevo.Type,
                    desctiption = nuevo.Desc,
                    idS = nuevo.IdS,
                    idSc = nuevo.IdSc,
                    modifyUser = user
                };

                string json = JsonConvert.SerializeObject(customer);

                dynamic respuesta = dBApi.Post("Garment", "UpdateGarment", json);

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

                Garment customer = new Garment
                {
                    idG = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(customer);

                dynamic respuesta = dBApi.Post("Garment", "DeleteGarment?idG=" + a, json);

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
