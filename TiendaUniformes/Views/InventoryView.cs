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
    public partial class InventoryView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public InventoryView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("Inventory", "GetInventory?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idI;
                    row.Cells[1].Value = item.idSc;
                    row.Cells[2].Value = item.idG;
                    row.Cells[3].Value = item.quantitaty;
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
                InventoryCM nuevo = new InventoryCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel || string.IsNullOrEmpty(nuevo.IdSc.ToString()))
                    return;

                Inventory inventory = new Inventory
                {
                    idSc = nuevo.IdSc,
                    idG = nuevo.IdG,
                    quantitaty = nuevo.Qty,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(inventory);

                dynamic respuesta = dBApi.Post("Inventory", "CreateInventory", json);

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
                InventoryCM nuevo = new InventoryCM();
                var ids = dgList.CurrentRow.Cells[1].Value.ToString();
                var idg = dgList.CurrentRow.Cells[2].Value.ToString();
                var cant = dgList.CurrentRow.Cells[3].Value.ToString();
                nuevo.NameBtn(true, ids!, idg!, cant!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                Inventory inventory = new Inventory
                {
                    idI = int.Parse(a!),
                    idSc = nuevo.IdSc,
                    idG = nuevo.IdG,
                    quantitaty = nuevo.Qty,
                    modifyUser = user
                };

                string json = JsonConvert.SerializeObject(inventory);

                dynamic respuesta = dBApi.Post("Inventory", "UpdateInventory", json);

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

                Inventory inventory = new Inventory
                {
                    idI = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(inventory);

                dynamic respuesta = dBApi.Post("Inventory", "DeleteInventory?idI=" + a, json);

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
