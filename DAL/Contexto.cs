using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisMedico.Entidades;
using System.Data.Entity;

namespace AnalisisMedico.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Analisis> Analisi { get; set; }
        public DbSet<TipoAnalisis> TipoAnali { get; set; }
        public Contexto() : base("ConStr")
        {

        }
    }
}
