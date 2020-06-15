using ParadaCerta_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.DataLayer
{
    public class ParadaCertaContexto : DbContext
    {
        public ParadaCertaContexto() : base("ParadaCertaContexto")
        {

        }

        public DbSet<Credencial> Credencial { get; set; }
        public DbSet<RegistroLogin> RegistroLogin { get; set; }
        public DbSet<Pessoas> Pessoa { get; set; }
        public DbSet<Parceiros> Parceiros { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Produtos> Produto { get; set; }
    }
}