using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Models
{
    public class Credencial
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}