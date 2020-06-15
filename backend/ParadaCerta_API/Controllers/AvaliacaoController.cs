using ParadaCerta_API.Models;
using ParadaCerta_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParadaCerta_API.Controllers
{
    public class AvaliacaoController : ApiController
    {
        [ActionName("AvaliarParceiro")]
        [HttpPost]
        public string Avaliar(string dados_avaliacao)
        {
            var dados = Splitter(dados_avaliacao);
            var infos_avaliacao = new Avaliacao()
            {
                Id_Parceiro = Convert.ToInt32(dados[0]),
                Id_Motorista = Convert.ToInt32(dados[1]),
                Alimentacao_Nota = Convert.ToInt32(dados[2]),
                Banheiro_Nota = Convert.ToInt32(dados[3]),
                Seguranca_Nota = Convert.ToInt32(dados[4]),
                Alimentacao_Avaliacao = dados[5],
                Banheiro_Avaliacao = dados[6],
                Seguranca_Avaliacao = dados[7],
            };
            var aval = new AvaliacaoParceiro();

            return aval.AvaliarParceiro(infos_avaliacao, dados[8]);
        }


        private string[] Splitter(string infos)
        {
            return infos.Replace("{", "").Replace("}", "").Split(',');

        }
    }
}
