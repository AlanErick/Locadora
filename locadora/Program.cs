using locadora.Cadastro;
using locadora.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeFilmes = 0;
            
            Console.WriteLine("Quantos filmes deseja informar: ");
            quantidadeDeFilmes = Console.Read();
            Console.ReadLine();

            Filme[] filmes = new Filme[quantidadeDeFilmes];

            Filme filme1 = new Filme("Anabelle", 1, "Adulto", 5);
            Cliente cliente = new Cliente("Alan", "123.456.789-10", "Rua 12, 145", 25, 05, 1997);
            AluguelFilmes aluguel = new AluguelFilmes();

            Console.WriteLine(filme1.Nome + " " + filme1.Classificacao + " " + filme1.QuantidadeEstoque);
            Console.WriteLine(cliente.Nome + " " + cliente.StatusCliente);
            aluguel.Alugar(filme1, cliente);

            Console.WriteLine(filme1.Nome + " " + filme1.StatusFilme + " " + filme1.QuantidadeEstoque);
            
            Console.ReadLine();
        }
    }
}
