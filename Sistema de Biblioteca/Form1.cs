using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Biblioteca
{
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "sistema_de_biblioteca";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ativoLivro = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgBiblioteca.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgBiblioteca.Rows[0].Clone(); // Faz um CAST e clona as linhas da tabela;
                    row.Cells[0].Value = reader.GetInt32(0); // ID do Livro;
                    row.Cells[1].Value = reader.GetString(1); // Nome do Livro;
                    row.Cells[2].Value = reader.GetString(2); // Autor;
                    row.Cells[3].Value = reader.GetString(3); // Descrição;
                    row.Cells[4].Value = reader.GetString(4); // categoria;
                    row.Cells[5].Value = reader.GetString(5); // Ano;
                    dgBiblioteca.Rows.Add(row); //  Adiciona uma linha na tabela.
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar com o Banco de Dados !");
                Console.WriteLine(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgBiblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBiblioteca.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgBiblioteca.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbID.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                tbNome.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbAutor.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colAutor"].FormattedValue.ToString();
                tbDescricao.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
                tbCategoria.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
                tbAno.Text = dgBiblioteca.Rows[e.RowIndex].Cells["colAno"].FormattedValue.ToString();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            tbID.Clear();
            tbNome.Clear();
            tbAutor.Clear();
            tbDescricao.Clear();
            tbCategoria.Clear();
            tbAno.Clear();
        }

        private void tbAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO livro (nomeLivro,idAutor,descricaoLivro,categoriaLivro,anoLivro) " +
                    "VALUES('" + tbNome.Text + "','" + tbAutor.Text + "','" + tbDescricao.Text + "','" + tbCategoria.Text + "', " + Convert.ToInt16(tbAno.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE livro SET ativoLivro = 0 WHERE idLivro = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE livro SET nomeLivro = '" + tbNome.Text + "', " +
                    "idAutor = '" + tbAutor.Text + "', " +
                    "descricaoLivro = '" + tbDescricao.Text + "', " +
                    "categoriaLivro = '" + tbCategoria.Text + "', " +
                    "anoLivro = " + Convert.ToInt16(tbAno.Text) +
                    " WHERE idLivro = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void tbDescricao_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
