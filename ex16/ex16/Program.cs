using System;
using static ex16.Exercicio;

namespace Course {
    class program {
        static void Main(string[] args) {

            Porta porta1 = new Porta(2.10, 0.90, false);
            Console.WriteLine("Porta1: Altura={0}, Largura={1}, Aberta={2}", porta1.Altura, porta1.Largura, porta1.Aberta);

            Porta porta2 = (Porta)porta1.Clone();
            Console.WriteLine("Porta2: Altura={0}, Largura={1}, Aberta={2}", porta2.Altura, porta2.Largura, porta2.Aberta);

            porta1.Abrir();
            Console.WriteLine("Porta1: Altura={0}, Largura={1}, Aberta={2}", porta1.Altura, porta1.Largura, porta1.Aberta);
            Console.WriteLine("Porta2: Altura={0}, Largura={1}, Aberta={2}", porta2.Altura, porta2.Largura, porta2.Aberta);

        }
    }
}