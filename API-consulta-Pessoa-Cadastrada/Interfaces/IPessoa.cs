using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testing_app.Model;

namespace API_consulta_Pessoa_Cadastrada.Interfaces
{
    public interface IPessoa
    {
        public IEnumerable<Pessoa> Get();
        public bool Cadastrar(Pessoa p);
    }
}
