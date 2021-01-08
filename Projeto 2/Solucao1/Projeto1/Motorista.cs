using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Motorista
    {
        public string nome;
        private long cpf;
        public long identidade;
        public int idade;
        public string sexo;
        Carro car = new Carro();

        public long Cpf { get => cpf; set => cpf = value; }
    }
}
