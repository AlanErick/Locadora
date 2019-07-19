using locadora.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.Sistema
{
    public class AluguelFilmes
    { 
        public bool AluguelStatus { get; set; }

        public bool Alugar(Filme filme, Cliente cliente)
        {
            int quantidade = filme.QuantidadeEstoque;
           
            //Aluga o filme somente se estiver no estoque e a classificacao bater.
            if (quantidade > 0 && (filme.StatusFilme == cliente.StatusCliente))
            {
                filme.QuantidadeEstoque--;   
                Console.WriteLine("Filme alugado.");
                return AluguelStatus = true;
            }
            else{
                Console.WriteLine("Filme não disponível em Estoque!");
                return AluguelStatus = false;
            }
        }
    }
}
