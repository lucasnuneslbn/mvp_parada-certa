using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace ParadaCerta_API.Models
{
    public class Parceiros
    {
        public int Id { get; set; }
        public int Id_Pessoa { get; set; }
        public int Id_Credencial { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int SERV_Abast { get; set; }
        public int SERV_Med { get; set; }
        public int SERV_Psico { get; set; }
        public int SERV_Odonto { get; set; }
        public int SERV_Borracharia { get; set; }
        public int SERV_Funilaria { get; set; }
        public int SERV_Refeicoes { get; set; }
        public int SERV_Mecan { get; set; }
        public int FL_ALoj { get; set; }
        public int FL_Desc { get; set; }
        public int FL_Conv { get; set; }
        public int FL_Ducha { get; set; }
        public int FL_Estac { get; set; }
        public int FL_Vest { get; set; }
        public int FL_Wifi { get; set; }
        public int BRD_Bone { get; set; }
        public int BRD_Luva { get; set; }
        public int BRD_Bota { get; set; }
        public int BRD_Cuia { get; set; }
        public int BRD_Frigideira { get; set; }
    }
}