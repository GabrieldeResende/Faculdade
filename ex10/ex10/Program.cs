using ex10;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Fracao f1 = new Fracao(1, 2);
            Fracao f2 = new Fracao(3, 4);
            Fracao f3 = f1.Multiplica(f2);

            Console.WriteLine($"Resultado da multiplicação: {f3}");
        }
    }
}