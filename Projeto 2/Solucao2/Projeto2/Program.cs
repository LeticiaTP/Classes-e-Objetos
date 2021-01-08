using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma tur = new Turma();
            tur.numeroDaSala = 10;
            tur.numeroDaTurma = 2;
            tur.disciplina = "Banco de dados";
            tur.bloco = "bloco desta turma";
            tur.disponivel = "disponível 100%";

            Professor pro = new Professor();
            pro.nome = "Luiz";
            pro.sexo = "Masculino";
            pro.chapa = "chapa deste professor";
            pro.Cpf = 12345678910;
            pro.identidade = 12345678;

            Aluno alu = new Aluno();
            alu.nome = "Mateus";
            alu.sexo = "Masculino";
            alu.matricula = 1234567890;
            alu.Cpf = 32145678901;
            alu.identidade = 32145678;
            alu.curso = "ads";




        }
    }
}
