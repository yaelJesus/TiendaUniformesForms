using Newtonsoft.Json;
using System.Text.RegularExpressions;
using TiendaUniformes.ApiRest;
using TiendaUniformes.School;
using TiendaUniformesAPI.Models;

namespace TiendaUniformes
{
    public partial class Login : Form
    {
        DBApi dBApi = new DBApi();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = txtUser.Text;
                bool tipoEntrada = VerificarEntrada(entrada);

                User user = new User
                {
                    userName = tipoEntrada ? "" : txtUser.Text,
                    email = tipoEntrada ? txtUser.Text : "",
                    pass = txtPass.Text,
                };

                string json = JsonConvert.SerializeObject(user);

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

        private bool VerificarEntrada(string texto)
        {
            string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            Regex regexCorreo = new Regex(pattern);

            if (regexCorreo.IsMatch(texto))
                return true;
            return false;
        }

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register view = new Register();
            Hide();
            if (view.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
