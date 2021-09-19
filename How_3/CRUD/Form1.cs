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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Conexão banco dados
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "cadastrodisciplinas";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        // atualização do grid
        private void AtualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM disciplina";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgDisciplinas.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgDisciplinas.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetInt32(4);
                    row.Cells[5].Value = reader.GetInt32(5);
                    row.Cells[6].Value = reader.GetInt32(6);
                    row.Cells[7].Value = reader.GetInt32(7);
                    dgDisciplinas.Rows.Add(row);
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
        // limpeza de campos
        private void LimparCampos()
        {
            tbId.Clear();
            tbNome.Clear();
            tbNomeCompleto.Clear();
            tbCreditosAcademicos.Clear();
            tbCreditosFinanceiros.Clear();
            tbCargaHoraria.Clear();
            tbDuracaoAula.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        // função salva insert
        private void buttonsSalvar_Click(object sender, EventArgs e)
        {
            //conecta ao bd
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
               //comando sql insert
                comandoMySql.CommandText = "INSERT INTO disciplina (Nome,NomeCompleto,NivelEnsino,CreditosAcademicos,CreditosFinanceiros,CargaHoraria,DuracaoAula) " +
                    "VALUES('" + tbNome.Text + "', '" + tbNomeCompleto.Text + "','" + cbNivelEnsino.Text + "'," + Convert.ToInt32(tbCreditosAcademicos.Text) + ", " + Convert.ToInt32(tbCreditosFinanceiros.Text) + ", " + Convert.ToInt32(tbCargaHoraria.Text) + ", " + Convert.ToInt32(tbDuracaoAula.Text) + ")";
                comandoMySql.ExecuteNonQuery();
                //encerra conexão com bd
                realizaConexacoBD.Close();
                //mensagem de insert
                MessageBox.Show("Inserido com sucesso");
                AtualizarGrid();
                LimparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // função edita um insert
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                //conecta ao bd
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                //comando sql update
                comandoMySql.CommandText = "UPDATE disciplina SET nome= '" + tbNome.Text + "', " + "NomeCompleto = '" + tbNomeCompleto.Text + "', " + "NivelEnsino = '" + cbNivelEnsino.Text + "', " + "CreditosAcademicos = '" + tbCreditosAcademicos.Text + "', " + "CreditosFinanceiros = '" + tbCreditosFinanceiros.Text + "', " + "CargaHoraria = '" + tbCargaHoraria.Text + "', " + "DuracaoAula = '" + tbDuracaoAula.Text + "' " + " WHERE id = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();
                //encerra conexão com bd
                realizaConexacoBD.Close();
                //mensagem de atualização
                MessageBox.Show("Atualizado com sucesso");
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //função deleta insert
        private void buttonDeletar_Click(object sender, EventArgs e)

        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                //conecta ao bd
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                //comando sql delete
                comandoMySql.CommandText = "DELETE FROM disciplina WHERE id = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();
                //encerra conexão com bd
                realizaConexacoBD.Close();
                //mensagem de delete
                MessageBox.Show("Deletado com sucesso!");
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        //função que popula o tb
            private void dgDisciplinas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                dgDisciplinas.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbNome.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                tbNomeCompleto.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnNomeCompleto"].FormattedValue.ToString();
                cbNivelEnsino.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnNivelEnsino"].FormattedValue.ToString();
                tbCreditosAcademicos.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnCreditosAcademicos"].FormattedValue.ToString();
                tbCreditosFinanceiros.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnCreditosFinanceiros"].FormattedValue.ToString();
                tbCargaHoraria.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnCargaHoraria"].FormattedValue.ToString();
                tbDuracaoAula.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnDuracaoAula"].FormattedValue.ToString();
                tbId.Text = dgDisciplinas.Rows[e.RowIndex].Cells["ColumnID"].FormattedValue.ToString();
            }
        }
    }
}
