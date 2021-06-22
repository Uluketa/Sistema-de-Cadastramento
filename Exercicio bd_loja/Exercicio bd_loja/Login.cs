using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Exercicio_bd_loja
{
    public partial class Login : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                string sql = @"select * from tb_usuarios where email = @email and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, con);

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                con.Open();

                MySqlDataReader dr = executacmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Bem vindo ao sistema!");
                    var form = new Form1();
                    this.Hide();
                    form.Show();
                }

                else
                {
                    MessageBox.Show("Dados incorretos, tente novamente!");
                }

                con.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o seguinte erro: " + erro);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            var form = new cadastrar();
            this.Hide();
            form.Show();
        }
    }
}
