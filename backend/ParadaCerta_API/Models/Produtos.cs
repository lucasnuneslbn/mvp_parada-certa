using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public int Id_Parceiro { get; set; }
        public string Descricao { get; set; }
        public decimal Vlr_Reais { get; set; }
        public decimal Vlr_Pontos { get; set; }
        public string Foto { get; set; }
    }
}