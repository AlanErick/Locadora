using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.Cadastro
{
    public class Filme
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Classificacao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool StatusFilme { get; set; }

        public Filme(string nome, int id, string classificacao, int quantidadeEstoque)
        {
            Nome = nome;
            Id = id;
            Classificacao = classificacao;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public bool ClassificacaoFilme()
        {
            if (Classificacao == "Adulto")
            {
                return StatusFilme = false;
            }
            else
            {
                return StatusFilme = true;
            }
        }
    }
}
