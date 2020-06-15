using ParadaCerta_API.DTO;
using ParadaCerta_API.Models;
using ParadaCerta_API.Services;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParadaCerta_API.Controllers
{
    public class CadastroController : ApiController
    {
        [ActionName("cadastraUsuario")]
        [HttpPost]
        public string CadastraUsuario(string dados_usuario)
        {
            var dados = Splitter(dados_usuario);
            var cad = new Cadastro();
            return cad.CadastrarUsuario(new Pessoas { Nome = dados[0], Email = dados[1], Telefone = dados[2] }, new Credencial { Usuario = dados[3],  Senha = dados[4]}, dados[5]);
        }

        [ActionName("cadastraParceiro")]
        [HttpPost]
        public string CadastraParceiro(string dados_parceiro)
        {
            var dados = Splitter(dados_parceiro);
            var cad = new Cadastro();
            var pessoa = new Pessoas {
                Nome = dados[0],
                Email = dados[1],
                Telefone = dados[4]
            };

            var credencial = new Credencial {
                Usuario = dados[5],
                Senha = dados[6]
            };

            var parceiro = new Parceiros{ 
                Latitude = dados[2],
                Longitude = dados[3],
                SERV_Abast = Convert.ToInt32(dados[7]),
                SERV_Med = Convert.ToInt32(dados[8]),
                SERV_Psico = Convert.ToInt32(dados[9]),
                SERV_Odonto = Convert.ToInt32(dados[10]),
                SERV_Borracharia = Convert.ToInt32(dados[11]),
                SERV_Funilaria = Convert.ToInt32(dados[12]),
                SERV_Refeicoes = Convert.ToInt32(dados[13]),
                SERV_Mecan = Convert.ToInt32(dados[14]),
                //****************************************
                FL_ALoj = Convert.ToInt32(dados[15]),
                FL_Desc = Convert.ToInt32(dados[16]),
                FL_Conv = Convert.ToInt32(dados[17]),
                FL_Ducha = Convert.ToInt32(dados[18]),
                FL_Estac = Convert.ToInt32(dados[19]),
                FL_Vest = Convert.ToInt32(dados[20]),
                FL_Wifi = Convert.ToInt32(dados[21]),
                //********************************************
                BRD_Bone = Convert.ToInt32(dados[22]),
                BRD_Bota = Convert.ToInt32(dados[23]),
                BRD_Cuia = Convert.ToInt32(dados[24]),
                BRD_Frigideira = Convert.ToInt32(dados[25]),
                BRD_Luva = Convert.ToInt32(dados[26]),
            };
            return cad.CadastroPerceiro(pessoa, credencial, parceiro, dados[27]) ;
        }

        //EditarParceiro
        //EditarUsuario

        //DeletarParceiro
        //DeletarUsuario

        private string[] Splitter(string infos)
        {
            return infos.Replace("{", "").Replace("}", "").Split(',');

        }
    }
}
