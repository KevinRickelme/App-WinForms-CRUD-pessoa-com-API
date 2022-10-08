using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing_app.Model;

namespace testing_app
{
    public partial class app : Form
    {
        private HttpClient _client;
        public app()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44361/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void app_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Telefone tel = new Telefone();
            tel.DDD = 11;
            tel.Numero = "";
            tel.TipoTelefone = TipoTelefone.Telefone;

            Endereco end = new Endereco();
            end.Logradouro = "Rua 123, xx";
            end.Numero = "123123";
            end.Bairro = "bairro1";
            end.Cidade = "São Paulo";
            end.UF = "SP";

            pessoa.Nome = "Teste";
            pessoa.RG = "00.000.222-3";
            pessoa.CPF = "000.123.456-11";
            pessoa.Telefone = tel;
            pessoa.Endereco = end;

            CadastrarPessoa(pessoa);

            
            //var resposta = _client.SendAsync(response);
        }

        public async void CadastrarPessoa(Pessoa pessoa) {
            var response = await _client.PostAsJsonAsync("Pessoa/CadastrarPessoa", pessoa).ConfigureAwait(false);
            //var send = await _client.SendAsync(response);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

    }
}
