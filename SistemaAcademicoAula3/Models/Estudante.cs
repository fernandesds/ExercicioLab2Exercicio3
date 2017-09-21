using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademicoAula3.Models
{
    public class Estudante
    {
        public int EstudanteID { get; set; }
        public string NomeEstudante { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public List<Curso> Curso { get; set; }
        public Endereco Endereco { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
        public int EnderecoID { get; set; }
    }
}