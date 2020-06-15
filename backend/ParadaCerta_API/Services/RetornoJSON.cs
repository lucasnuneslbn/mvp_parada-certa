using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParadaCerta_API.Services
{
    public class RetornoJSON
    {
        public string RetornarJson(Dictionary<string, string> infos)
        {
            var js = JsonConvert.SerializeObject(infos);

            return js;
        }
    }
}