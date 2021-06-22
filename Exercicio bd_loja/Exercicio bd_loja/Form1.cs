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
    public partial class Form1 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarfornecedores();
        }

        public void listarfornecedores()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_fornecedores = @"select * from tb_fornecedores";

                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_fornecedores, con);

                con.Open();

                executacmdMySql_select.ExecuteNonQuery();

                DataTable tabela_fornecedores = new DataTable();

                MySqlDataAdapter da_fornecedores = new MySqlDataAdapter(executacmdMySql_select);

                da_fornecedores.Fill(tabela_fornecedores);

                dgvlistarforcedores.DataSource = tabela_fornecedores;

                con.Close();
                
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no código: " + erro);
            }
        }
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, email, cnpj, telefone, celular, cep, endereco, num, complemento, bairro, cidade, estado;

                nome = txtnome.Text;
                email = txtemail.Text;
                cnpj = txtcnpj.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                num = txtnum.Text;
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;

                string sql_insert = @"insert into tb_fornecedores (tb_fornecedores_nome, tb_fornecedores_cnpj, tb_fornecedores_email, tb_fornecedores_telefone, tb_fornecedores_celular, tb_fornecedores_cep, tb_fornecedores_endereco, tb_fornecedores_numero, tb_fornecedores_complemento, tb_fornecedores_bairro, tb_fornecedores_cidade, tb_fornecedores_estado)
                                        
                                      values(@fornecedores_nome, @fornecedores_cnpj, @fornecedores_email, @fornecedores_telefone, @fornecedores_celular, @fornecedores_cep, @fornecedores_endereco, @fornecedores_numero, @fornecedores_complemento, @fornecedores_bairro, @fornecedores_cidade, @fornecedores_estado)";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cnpj", cnpj);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_telefone", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_celular", celular);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cep", cep);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_endereco", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_numero", num);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_complemento", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cidade", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_bairro", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_estado", estado);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Cadastro Realizado!");

                listarfornecedores();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no código: " + erro);
            }
        }

        private void Dgvlistarfornecedores(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvlistarforcedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgvlistarforcedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = dgvlistarforcedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgvlistarforcedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = dgvlistarforcedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dgvlistarforcedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = dgvlistarforcedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = dgvlistarforcedores.CurrentRow.Cells[7].Value.ToString();
            txtnum.Text = dgvlistarforcedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = dgvlistarforcedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = dgvlistarforcedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = dgvlistarforcedores.CurrentRow.Cells[11].Value.ToString();
            txtestado.Text = dgvlistarforcedores.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnatualizar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string nome, email, cnpj, telefone, celular, cep, endereco, num, complemento, bairro, cidade, estado;
                int codigo;

                codigo = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                email = txtemail.Text;
                cnpj = txtcnpj.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                num = txtnum.Text;
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_fornecedor = @"update tb_fornecedores set tb_fornecedores_nome = @nome, tb_fornecedores_cnpj = @cnpj, tb_fornecedores_email = @email, tb_fornecedores_telefone = @telefone, tb_fornecedores_celular = @celular, tb_fornecedores_cep = @cep, tb_fornecedores_endereco = @endereco, tb_fornecedores_numero = @numero, tb_fornecedores_complemento = @complemento, tb_fornecedores_bairro = @bairro, tb_fornecedores_cidade = @cidade, tb_fornecedores_estado = @estado where tb_fornecedores_id = @id";

                MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);

                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", codigo);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@cnpj", cnpj);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@email", email);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@telefone", telefone);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@celular", celular);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@cep", cep);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@endereco", endereco);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@numero", num);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@complemento", complemento);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@bairro", bairro);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@cidade", cidade);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@estado", estado);

                executacmdMySql_update_fornecedor.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Atualizado com sucesso!");

                listarfornecedores();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no código: " + erro);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja Realmente excluir o forncedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    int id = int.Parse(txtcodigo.Text);

                    string sql_delete_fornecedor = @"delete from tb_fornecedores where tb_fornecedores_id = @id";

                    MySqlCommand execultacmdMySql_delete = new MySqlCommand(sql_delete_fornecedor, con);
                    execultacmdMySql_delete.Parameters.AddWithValue("@id", id);

                    con.Open();

                    execultacmdMySql_delete.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("O fornecedor foi excluido com sucesso!");

                    listarfornecedores();
                }

                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu o seguinte erro: " + erro);
                }
            }

            else
            {
                MessageBox.Show("Você clicou em NÃO");
            }
        }
    }
}
