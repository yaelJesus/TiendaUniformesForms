using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaUniformes.ApiRest;
using TiendaUniformes.Models;

namespace TiendaUniformes
{
    public partial class Register : Form
    {
        DBApi dBApi = new DBApi();
        public Register()
        {
            InitializeComponent();
        }

        private bool VerificarEntrada(string texto)
        {
            string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            Regex regexCorreo = new Regex(pattern);

            if (regexCorreo.IsMatch(texto))
                return true;
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == txtPassC.Text && string.IsNullOrEmpty(txtPass.Text))
                    if (VerificarEntrada(txtMail.Text))
                        if (string.IsNullOrEmpty(txtUser.Text))
                        {
                            MessageBox.Show("Faltan campos por llenar.", "Advertecia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    else
                    {
                        MessageBox.Show("Favor de introducir un correo valido.", "Advertecia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Advertecia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                User user = new User
                {
                    userName = txtUser.Text,
                    email = txtMail.Text,
                    pass = txtPass.Text,
                };
                string json = JsonConvert.SerializeObject(user);

                //dynamic respuesta = dBApi.Post("User", "Register", json);
                dynamic respuesta = dBApi.Post("User", "Register", json);

                if (respuesta.status == 200)
                {
                    txtUser.Enabled = false;
                    txtMail.Enabled = false;
                    txtPass.Enabled = false;
                    txtPassC.Enabled = false;
                    btnRegister.Enabled = false;
                    MessageBox.Show("El registro fue hecho correctamente.", respuesta.title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
