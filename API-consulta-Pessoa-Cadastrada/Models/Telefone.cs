using System;
using System.Collections.Generic;
using System.Text;

namespace testing_app.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD{ get; set; }
        public string Numero{ get; set; }
        public TipoTelefone TipoTelefone{ get; set; }
    }
}
