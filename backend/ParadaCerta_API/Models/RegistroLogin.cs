using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Models
{
    public class RegistroLogin
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Session { get; set; }
        public DateTime DataLogin { get; set; }
        public bool Successful { get; set; }
    }
}