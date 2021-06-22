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
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string email, senha, nome;

                nome = txtnome.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;

                string sql = @"insert into tb_usuarios (nome, email, senha) values (@nome, @email, @senha);";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql, con);

                executacmdMySql_insert.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@senha", senha);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Cadastro Realizado!");
                var form = new Login();
                this.Hide();
                form.Show();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o seguinte erro: " + erro);
            }
        }
    }
}
