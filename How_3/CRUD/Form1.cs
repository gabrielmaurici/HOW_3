using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Repository;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        DisciplinaRepository repositorio = new DisciplinaRepository();
        public Form1()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        // atualização do grid
        private void AtualizarGrid()
        {
            try
            {
                List<Disciplina> listaDisciplinas = new List<Disciplina>();

                // Chama o método da classe DisciplinaRepository que traz todas as Disciplinas do DataGrid e armazena na lista Disciplinas
                listaDisciplinas = repositorio.ListarGrid();

                //Limpa o DataGrid para receber os dados do Db novamente
                dgDisciplinas.Rows.Clear();
                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    DataGridViewRow row = (DataGridViewRow)dgDisciplinas.Rows[0].Clone();
                    row.Cells[0].Value = disciplina.Id;
                    row.Cells[1].Value = disciplina.Nome;
                    row.Cells[2].Value = disciplina.NomeCompleto;
                    row.Cells[3].Value = disciplina.NivelEnsino;
                    row.Cells[4].Value = disciplina.CreditosAcademicos;
                    row.Cells[5].Value = disciplina.CreditosFinanceiros;
                    row.Cells[6].Value = disciplina.CargaHoraria;
                    row.Cells[7].Value = disciplina.DuracaoAula;
                    dgDisciplinas.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show("Não conseguimos efetuar a conexão com o Banco de Dados... Por favor tente mais tarde!");
            }
        }
        // função salva insert
        private void buttonsSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina = new Disciplina();

                disciplina.Id = 0;
                disciplina.Nome = tbNome.Text;
                disciplina.NomeCompleto = tbNomeCompleto.Text;
                disciplina.NivelEnsino = cbNivelEnsino.Text;
                disciplina.CreditosAcademicos = Convert.ToInt32(tbCreditosAcademicos.Text);
                disciplina.CreditosFinanceiros = Convert.ToInt32(tbCreditosFinanceiros.Text);
                disciplina.CargaHoraria = Convert.ToInt32(tbCargaHoraria.Text);
                disciplina.DuracaoAula = Convert.ToInt32(tbDuracaoAula.Text);

                // Chama o método InserirDiscíplinas da Classe DisciplinaRepository que insere a disciplina no banco de dados
                repositorio.InserirDisciplina(disciplina);

                //mensagem de insert
                MessageBox.Show("Inserido com sucesso");
                AtualizarGrid();
                LimparCampos();
            }
            catch
            {
                Console.WriteLine("Não conseguimos efetuar a conexão com o Banco de Dados... Por favor tente mais tarde!");
            }
        }
        // função edita um insert
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina = new Disciplina();

                disciplina.Id = Convert.ToInt32(tbId.Text);
                disciplina.Nome = tbNome.Text;
                disciplina.NomeCompleto = tbNomeCompleto.Text;
                disciplina.NivelEnsino = cbNivelEnsino.Text;
                disciplina.CreditosAcademicos = Convert.ToInt32(tbCreditosAcademicos.Text);
                disciplina.CreditosFinanceiros = Convert.ToInt32(tbCreditosFinanceiros.Text);
                disciplina.CargaHoraria = Convert.ToInt32(tbCargaHoraria.Text);
                disciplina.DuracaoAula = Convert.ToInt32(tbDuracaoAula.Text);

                // Chama método de Editar Disciplina na classe DisciplinaRepository
                repositorio.Editar(disciplina);

                //mensagem de atualização
                MessageBox.Show("Atualizado com sucesso");
                AtualizarGrid();
                LimparCampos();
            }
            catch
            {
                MessageBox.Show("Não foi possível se conectar com o Banco de Dados... Por favor tente editar sua disciplina mais tarde!");
            }
        }
        //função deleta insert
        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbId.Text);
                //Chama método Deletar para deletar disciplina na classe DisciplinaRepository
                repositorio.Deletar(id);

                //mensagem de delete
                MessageBox.Show("Deletado com sucesso!");
                AtualizarGrid();
                LimparCampos();
            }
            catch
            {
                Console.WriteLine("Não foi possível se conectar com o Banco de Dados... Por favor tente deletar sua disciplina mais tarde!");
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
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //função que popula o tb
        private void dgDisciplinas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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