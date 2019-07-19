using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.Cadastro
{
    public class DataNascimento
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public bool StatusNascimento { get; set; }

        public bool GetDataNascimento(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;

            //Status false = menor de idade
            if(Ano <= 2000)
            {
                return StatusNascimento = false;
            }
            else
            {
                return StatusNascimento = true;
            }
        }

    }
}
