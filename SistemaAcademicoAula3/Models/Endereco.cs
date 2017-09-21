using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaAcademicoAula3.Models
{
    public class Endereco
    {
        // Estudante Assume a responsabilidade de PK e FK
        [ForeignKey("Estudante")]
        public int EnderecoId { get; set; }
        public Estudante Estudante { get; set; }
        public int EstudanteId { get; set; }
        public string Endereco1 { get; set; }
        public string Endereco2 { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
    }
}