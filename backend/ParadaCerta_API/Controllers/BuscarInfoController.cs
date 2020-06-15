using ParadaCerta_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParadaCerta_API.Controllers
{
    public class BuscarInfoController : ApiController
    {
        [ActionName("buscaParceiros")]
        [HttpPost]
        public string BuscarParceiros(string dados_busca)
        {
            var dados = Splitter(dados_busca);
            var busca = new RetornarInfos();

            return busca.BuscarParceiros(dados[2].Replace("-", "").Trim(), dados[3].Replace("-", "").Trim(), dados[1]);
        }

        [ActionName("buscaProdutos")]
        [HttpPost]
        public string BuscarProdutos(string dados_busca)
        {
            var dados = Splitter(dados_busca);
            var busca = new RetornarInfos();

            return busca.BuscarProdutos(dados[2].Replace("-", "").Trim(), dados[3].Replace("-", "").Trim(), dados[1]);
        }

        private string[] Splitter(string infos)
        {
            return infos.Replace("{", "").Replace("}", "").Split(',');

        }
    }
}
