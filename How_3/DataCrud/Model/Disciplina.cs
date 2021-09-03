using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrud
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string NivelEnsino { get; set; }
        public int CreditosAcademicos { get; set; }
        public int CreditosFinanceiros { get; set; }
        public int CargaHoraria { get; set; }
        public int DuracaoAula { get; set; }
    }
}
