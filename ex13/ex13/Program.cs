using ex13;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Lampada lampada = new Lampada(true);

            lampada.Imprimir(); // Lâmpada ligada

            lampada.Desligar();

            lampada.Imprimir(); // Lâmpada desligada

            lampada.Ligar();

            lampada.Imprimir(); // Lâmpada ligada
        }
    }
}