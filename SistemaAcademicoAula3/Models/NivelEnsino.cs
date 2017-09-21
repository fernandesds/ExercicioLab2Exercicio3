using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademicoAula3.Models
{
    public class NivelEnsino
    {
        public int NivelEnsinoId { get; set; }
        public string Descricao { get; set; }
        public List<Estudante> Estudante { get; set; }
        public List<Professor> Professor { get; set; }
    }
}