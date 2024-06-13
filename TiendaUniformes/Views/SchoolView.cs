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
using TiendaUniformesAPI.Models;

namespace TiendaUniformes.Views
{
    public partial class SchoolView : Form
    {
        DBApi dBApi = new DBApi();
        public SchoolView(int id)
        {
            InitializeComponent();
            GetSchools(id);
        }

        private void GetSchools(int id)
        {
            try
            {
                dynamic respuesta = dBApi.Get("http://192.168.100.17/api/School/GetSchool?IdU=" + id);
                foreach (var item in respuesta.data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgSchoolsList);

                    row.Cells[0].Value = item.idSc;
                    row.Cells[1].Value = item.name;

                    dgSchoolsList.Rows.Add(row);
                }
            }
            catch (Exception)
            { }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                School school = new School
                {
                    idSc = 0
                };

                string json = JsonConvert.SerializeObject(school);

                dynamic respuesta = dBApi.Post("http://192.168.100.17/api/User/Login", json);

                if (respuesta.status == 200)
                {
                    Menu view = new Menu();
                    this.Hide();
                    view.User = respuesta.data.idU;
                    view.Show();
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
