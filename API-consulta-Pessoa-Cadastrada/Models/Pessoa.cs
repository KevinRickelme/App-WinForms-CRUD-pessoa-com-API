using System;
using System.Collections.Generic;
using System.Text;

namespace testing_app.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF{ get; set; }
        public string RG{ get; set; }
        public Endereco? Endereco{ get; set; }
        public Telefone? Telefone{ get; set; }

    }
}
