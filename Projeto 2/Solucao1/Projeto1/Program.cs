using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.placa = "ABC5687";
            car.marca = "Chevrolet";
            car.modelo = "Novo Onix";
            car.chassi = "a0b9c8d7e6f5g4";
            Motorista mot = new Motorista();
            mot.nome = "João";
            mot.Cpf = 12345678901;
            mot.identidade = 12345678;
            mot.idade = 45;
            mot.sexo = "Masculino";
        }
    }
}
