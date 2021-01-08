using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Aluno
    {
       public string nome;
       public string sexo;
       public long matricula;
       private long cpf;
       public long identidade;
       public string curso;

        public long Cpf { get => cpf; set => cpf = value; }
    }
}
