using ParadaCerta_API.DataLayer;
using ParadaCerta_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Services
{
    public class AvaliacaoParceiro
    {
        public string AvaliarParceiro(Avaliacao avaliacao, string session_number)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            retorno.Add("session", session_number);
            var js = new RetornoJSON();

            try
            {   
                using (ParadaCertaContexto con = new ParadaCertaContexto())
                {
                    con.Avaliacoes.Add(avaliacao);
                    con.SaveChanges();
                }
                retorno.Add("type", "success");
                return js.RetornarJson(retorno);
            }
            catch (Exception err)
            {
                retorno.Add("type", "fail");
                retorno.Add("type", err.Message);

                return js.RetornarJson(retorno);
            }
        }
    }
}