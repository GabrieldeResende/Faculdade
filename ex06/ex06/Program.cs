using System;

namespace ImprimirValoresX {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor inteiro para x: ");
            int x = int.Parse(Console.ReadLine());

            while (x <= 1000) {
                Console.WriteLine(x);

                if (x % 2 == 0) {
                    x += 5;
                }
                else {
                    x *= 2;
                }
            }
            /*Console.Write("Digite um valor inteiro para x: ");
            int x = int.Parse(Console.ReadLine());

            while (x <= 1000) {
                Console.WriteLine(x);

                switch (x % 2) {
                    case 0:
                        x += 5;
                        break;
                    case 1:
                        x *= 2;
                        break;
                }
            } */
        }
    }
}