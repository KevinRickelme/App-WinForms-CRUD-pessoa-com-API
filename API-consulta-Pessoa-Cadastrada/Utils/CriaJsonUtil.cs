using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_consulta_Pessoa_Cadastrada.Utils
{
    public class CriaJsonUtil
    {
        public static string CriaJson(List<KeyValuePair<string, string>> lista)
        {
            String saida = "{";
            foreach (var item in lista)
            {
                if (item.Key != lista[0].Key)
                    saida += ",";
                saida += "\"" + item.Key + "\":";
                saida += "\"" + item.Value + "\"";
            }
            saida += "}";
            return saida;
        }
    }
}
