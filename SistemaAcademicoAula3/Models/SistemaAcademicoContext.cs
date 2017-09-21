using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaAcademicoAula3.Models
{
    public class SistemaAcademicoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SistemaAcademicoContext() : base("name=SistemaAcademicoContext")
        {
        }

        public System.Data.Entity.DbSet<SistemaAcademicoAula3.Models.Endereco> Enderecoes { get; set; }

        public System.Data.Entity.DbSet<SistemaAcademicoAula3.Models.Estudante> Estudantes { get; set; }

        public System.Data.Entity.DbSet<SistemaAcademicoAula3.Models.NivelEnsino> NivelEnsinoes { get; set; }

        public System.Data.Entity.DbSet<SistemaAcademicoAula3.Models.Curso> Cursoes { get; set; }

        public System.Data.Entity.DbSet<SistemaAcademicoAula3.Models.Professor> Professors { get; set; }
    }
}
