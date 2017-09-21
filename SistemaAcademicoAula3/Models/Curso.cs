using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademicoAula3.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<Estudante> Estudante { get; set; }
    }
}