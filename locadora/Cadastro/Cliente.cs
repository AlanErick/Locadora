using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.Cadastro
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public bool StatusCliente { get; private set; }
  
        public Cliente(string nome, string cpf, string endereco, int dia, int mes, int ano)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;

            DataNascimento data = new DataNascimento();
            StatusCliente = data.GetDataNascimento(dia, mes, ano);
    }
    }
}
