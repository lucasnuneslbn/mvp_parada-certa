using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Id_Parceiro { get; set; }
        public int Id_Motorista { get; set; }
        public int Banheiro_Nota { get; set; }
        public int Alimentacao_Nota { get; set; }
        public int Seguranca_Nota { get; set; }
        public string Banheiro_Avaliacao { get; set; }
        public string Alimentacao_Avaliacao { get; set; }
        public string Seguranca_Avaliacao { get; set; } 
    }
}