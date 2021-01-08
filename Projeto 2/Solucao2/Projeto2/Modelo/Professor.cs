using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Professor
    {
        public string nome;
        public string sexo;
        public string chapa;
        private long cpf;
        public long identidade;

        public long Cpf { get => cpf; set => cpf = value; }
    }
}
