using Data.Context;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class DisciplinaRepository
    {
        //Instância da classe ConexãoDb para ter acesso ao método que se conecta ao banco de dados
        ConexaoDb conexaoBanco = new ConexaoDb();

        //Método para inserir a disciplina no Banco de Dados
        public void InserirDisciplina(Disciplina model)
        {
            MySqlConnectionStringBuilder conexaoDb = conexaoBanco.conexaoBanco();
            MySqlConnection realizaConexacoDb = new MySqlConnection(conexaoDb.ToString());

            realizaConexacoDb.Open();

            MySqlCommand comandoMySql = realizaConexacoDb.CreateCommand();
            comandoMySql.CommandText = "INSERT INTO disciplinas(Id, Nome, NomeCompleto, NivelEnsino, CreditosAcademicos, CreditosFinanceiros, CargaHoraria, DuracaoAula) VALUES ('" + model.Id + "','" + model.Nome + "','" + model.NomeCompleto + "','" + model.NivelEnsino + "','" + model.CreditosAcademicos + "','" + model.CreditosFinanceiros + "','" + model.CargaHoraria + "','" + model.DuracaoAula + "')";

            comandoMySql.ExecuteNonQuery();
            //encerra conexão com bd
            realizaConexacoDb.Close();
        } 

        //Método para Listar o DataGrid
        public List<Disciplina> ListarGrid()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();

            MySqlConnectionStringBuilder conexaoDb = conexaoBanco.conexaoBanco();
            MySqlConnection realizaConexacoDb = new MySqlConnection(conexaoDb.ToString());

            realizaConexacoDb.Open();

            MySqlCommand comandoMySql = realizaConexacoDb.CreateCommand();
            //comando sql select
            comandoMySql.CommandText = "SELECT * FROM disciplinas";
            MySqlDataReader reader = comandoMySql.ExecuteReader();
            
            //Whille para armazenar todas as disciplinas na lista disciplinas
            while (reader.Read())
            {
                Disciplina disciplina = new Disciplina();
                disciplina.Id = reader.GetInt32(0);
                disciplina.Nome = reader.GetString(1);
                disciplina.NomeCompleto = reader.GetString(2);
                disciplina.NivelEnsino = reader.GetString(3);
                disciplina.CreditosAcademicos = reader.GetInt32(4);
                disciplina.CreditosFinanceiros = reader.GetInt32(5);
                disciplina.CargaHoraria = reader.GetInt32(6);
                disciplina.DuracaoAula = reader.GetInt32(7);

                disciplinas.Add(disciplina);
            }
            
            realizaConexacoDb.Close();
            return disciplinas;
        }

        //Método Editar Disciplinas
        public void Editar(Disciplina model)
        {
            MySqlConnectionStringBuilder conexaoDb = conexaoBanco.conexaoBanco();
            MySqlConnection realizaConexacoDb = new MySqlConnection(conexaoDb.ToString());

            realizaConexacoDb.Open();

            MySqlCommand comandoMySql = realizaConexacoDb.CreateCommand();
            //comando sql update
            comandoMySql.CommandText = "UPDATE disciplinas SET nome= '" + model.Nome + "', " + "NomeCompleto = '" + model.NomeCompleto + "', " + "NivelEnsino = '" + model.NivelEnsino + "', " + "CreditosAcademicos = '" + model.CreditosAcademicos + "', " + "CreditosFinanceiros = '" + model.CreditosFinanceiros + "', " + "CargaHoraria = '" + model.CargaHoraria + "', " + "DuracaoAula = '" + model.DuracaoAula + "' " + " WHERE id = " + model.Id + "";
            comandoMySql.ExecuteNonQuery();
            //encerra conexão com bd
            realizaConexacoDb.Close();
        }

        //Método para Deletar Disciplinas
        public void Deletar(int id)
        {
            MySqlConnectionStringBuilder conexaoDb = conexaoBanco.conexaoBanco();
            MySqlConnection realizaConexacoDb = new MySqlConnection(conexaoDb.ToString());

            realizaConexacoDb.Open();

            MySqlCommand comandoMySql = realizaConexacoDb.CreateCommand();
            //comando sql delete
            comandoMySql.CommandText = "DELETE FROM disciplinas WHERE Id = " + id + "";
            comandoMySql.ExecuteNonQuery();
            //encerra conexão com bd
            realizaConexacoDb.Close();
        }
    }
}