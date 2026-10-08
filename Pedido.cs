using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Pedido
    {
        public string CName;

        public string Item;

        public int Quantidade;

        public double Preco;

        public void ExibirPedido()
        {

            Console.WriteLine($"O nome do cliente é {CName}");
            Console.WriteLine($"O item do cliente é {Item}");
            Console.WriteLine($"A quantidade de itens do cliente é {Quantidade}");
            Console.WriteLine($"O preço do pedido do cliente é {Preco}");

        }

    }
}
