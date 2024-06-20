using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TemAqui.Models;

namespace Tem_Aqui.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<SerPres> SerPres { get; set; }

        public DbSet<TabelClientes> TabelClientes { get; set; }

        public DbSet<Prestadordeservico> Prestadordeservico { get; set; }

        public DbSet<Login> Login { get; set; }

        // public DbSet<Exame> Exame { get; set; }

        //public DbSet<Paciente> Paciente { get; set; }

        // public DbSet<Profissional> Profissional { get; set; }

        //public DbSet<Resultado> Resultado { get; set; }




    }
}