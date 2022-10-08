using API_consulta_Pessoa_Cadastrada.Data;
using API_consulta_Pessoa_Cadastrada.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testing_app.Model;

namespace API_consulta_Pessoa_Cadastrada.Repositories
{
    
    public class PessoaRepository : IPessoa
    {
        private readonly ApplicationDbContext _context;
        public PessoaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Cadastrar(Pessoa p)
        {
            try
            {
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }

        public IEnumerable<Pessoa> Get()
        {
            return _context.Pessoas.ToList();
        }

    }
}
