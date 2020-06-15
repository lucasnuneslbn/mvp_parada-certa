using Newtonsoft.Json;
using ParadaCerta_API.DataLayer;
using ParadaCerta_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace ParadaCerta_API.Services
{
    public class RetornarInfos
    {
        public string BuscarParceiros(string latitude, string longitude, string session_id)
        {
            Dictionary<string, dynamic> retorno = new Dictionary<string, dynamic>();
            retorno.Add("session", session_id);
            var js = new RetornoJSON();

            try
            {
                using (ParadaCertaContexto con = new ParadaCertaContexto())
                {
                    var str = new StringBuilder();
                    var lista = (from pa in con.Parceiros
                                 join pe in con.Pessoa on pa.Id_Pessoa equals pe.Id
                                 join a in con.Avaliacoes on pa.Id equals a.Id_Parceiro
                                 where pa.Latitude == latitude && pa.Longitude == longitude
                                 select new
                                 {
                                     a.Banheiro_Nota,
                                     a.Alimentacao_Nota,
                                     a.Seguranca_Nota,
                                     pe.Nome,
                                     pe.Telefone,
                                     pa.Latitude,
                                     pa.Longitude
                                 }).ToList();
                    if (lista != null)
                    {
                        
                        retorno.Add("type", "success");
                        List<object> json = new List<object>();
                        foreach (var item in lista)
                        {
                            Dictionary<string, string> avaliacoes = new Dictionary<string, string>();
                            Dictionary<string, dynamic> dados = new Dictionary<string, dynamic>();

                            dados.Add("nome", item.Nome);
                            dados.Add("telefone", item.Telefone);
                            dados.Add("latitude", item.Latitude);
                            dados.Add("longitude", item.Longitude);
                            avaliacoes.Add("banheiro", item.Banheiro_Nota.ToString());
                            avaliacoes.Add("alimentacao", item.Alimentacao_Nota.ToString());
                            avaliacoes.Add("seguranca", item.Seguranca_Nota.ToString());
                            dados.Add("avaliacoes", avaliacoes);
                           
                            json.Add(dados);
                        }

                        retorno.Add("data", json);
                    }
                    else
                    {
                        retorno.Add("type", "fail");
                        retorno.Add("type", "Parceiro Não Localizado");

                    }

                }

                    return JsonConvert.SerializeObject(retorno);

            }
            catch (Exception err)
            {
                retorno.Add("type", "fail");
                retorno.Add("type", err.Message);

                return JsonConvert.SerializeObject(retorno);
            
            }
        }
        public string BuscarProdutos(string latitude, string longitude, string session_id)
        {
            Dictionary<string, dynamic> retorno = new Dictionary<string, dynamic>();
            retorno.Add("session", session_id);

            try
            {           

                using (ParadaCertaContexto con = new ParadaCertaContexto())
                {
                    var infos = (from p in con.Parceiros
                                 join pe in con.Pessoa on p.Id_Pessoa equals pe.Id
                                 join pr in con.Produto on p.Id equals pr.Id_Parceiro
                                 where p.Latitude == latitude && p.Longitude == longitude
                                 select new
                                 {
                                     pr.Descricao,
                                     pr.Vlr_Reais,
                                     pr.Vlr_Pontos,
                                     pr.Foto,
                                     p.Longitude,
                                     p.Latitude,
                                     pe.Telefone,
                                     pe.Nome
                                 }).ToList();

                    if (infos == null)
                    {
                        retorno.Add("type", "fail");
                        return JsonConvert.SerializeObject(retorno);
                    }
                    List<object> json = new List<object>();

                    retorno.Add("type", "success");

                    foreach (var item in infos)
                    {
                        Dictionary<string, dynamic> dados = new Dictionary<string, dynamic>();
                        Dictionary<string, dynamic> dados_parceiro = new Dictionary<string, dynamic>();

                        dados.Add("titulo", item.Descricao);
                        dados.Add("valor_reais", item.Vlr_Reais);
                        dados.Add("valor_pontos", item.Vlr_Pontos);
                        dados.Add("foto", item.Foto);

                        dados_parceiro.Add("nome", item.Nome);
                        dados_parceiro.Add("telefone", item.Telefone);
                        dados_parceiro.Add("latitude", "-" + item.Latitude);
                        dados_parceiro.Add("longitude", "-" + item.Longitude);
                        dados.Add("dados_parceiro", dados_parceiro);

                        json.Add(dados);
                    }

                    retorno.Add("data", json);
                }

                return JsonConvert.SerializeObject(retorno);

            }
            catch (Exception err)
            {
                retorno.Add("type", "fail");
                retorno.Add("type", err.Message);

                return JsonConvert.SerializeObject(retorno);

            }
        }
    }
}