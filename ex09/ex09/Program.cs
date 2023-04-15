using ex09;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Relogio relogio = new Relogio();
            Console.WriteLine($"Hora atual: {relogio.LerHora()}:{relogio.LerMinuto()}:{relogio.LerSegundo()}");

            relogio.AcertarRelogio(10, 20, 30);
            Console.WriteLine($"Hora atual: {relogio.LerHora()}:{relogio.LerMinuto()}:{relogio.LerSegundo()}");
        }
    }
}