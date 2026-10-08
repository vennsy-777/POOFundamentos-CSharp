using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Carro
    {
        //Não obrigatorio ambos, mas obrigatorio um ou outro 
        // Atributos
        public string Marca;

        public string Modelo;
        public int Ano;


        //Metodo 
        // Mostrar inforções do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"Ano:{Ano}");


        }

    }
} 