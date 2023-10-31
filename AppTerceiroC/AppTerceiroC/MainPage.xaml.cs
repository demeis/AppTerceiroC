using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTerceiroC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Conexao.strConexao);
            MySqlCommand inserirNome = new MySqlCommand(ComandoSQL.inserirNome, conn);

            inserirNome.Parameters.AddWithValue("@nome", txtNome.Text);
            inserirNome.Parameters.AddWithValue("@cpf", txtCpf.Text);
            conn.Open();
            inserirNome.ExecuteNonQuery();
            conn.Close();

            txtNome.Text = "";
            txtCpf.Text = "";
            await DisplayAlert("Atenção", "Nome salvo com sucesso!", "ok");
        }
    }
}
