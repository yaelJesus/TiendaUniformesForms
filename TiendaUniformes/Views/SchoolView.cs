﻿using Newtonsoft.Json;
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
    public partial class SchoolView : Form
    {
        DBApi dBApi = new DBApi();
        private int user = 0;
        public SchoolView(int id)
        {
            InitializeComponent();
            user = id;
            Get();
        }

        private void Get()
        {
            try
            {
                dynamic respuesta = dBApi.Get("School", "GetSchool?IdU=" + user);
                dgList.Rows.Clear();
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgList);

                    row.Cells[0].Value = item.idSc;
                    row.Cells[1].Value = item.name;
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
                SchoolCM nuevo = new SchoolCM();
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                School school = new School
                {
                    name = nuevo.Nombre,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(school);

                dynamic respuesta = dBApi.Post("School", "CreateSchool", json);

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
                SchoolCM nuevo = new SchoolCM();
                var nombre = dgList.CurrentRow.Cells[1].Value.ToString();
                nuevo.NameBtn(true, nombre!);
                if (nuevo.ShowDialog() == DialogResult.Cancel)
                    return;

                var a = dgList.CurrentRow.Cells[0].Value.ToString();
                if (a == "0")
                    return;

                School school = new School
                {
                    idSc = int.Parse(a!),
                    name = nuevo.Nombre,
                    createUser = user
                };

                string json = JsonConvert.SerializeObject(school);

                dynamic respuesta = dBApi.Post("School", "UpdateSchool", json);

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

                School school = new School
                {
                    idSc = int.Parse(a!)
                };

                string json = JsonConvert.SerializeObject(school);

                dynamic respuesta = dBApi.Post("School", "DeleteSchool?idSc=" + a, json);

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
