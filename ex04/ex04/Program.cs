using System;


namespace Course {
    class program {
        static void Main(string[] args) {

            //4. Escreva um programa que calcule o fatorial de 10.
            int numero = 10;
            int fatorial = 1;

            for (int i = numero; i >= 1; i--) {
                fatorial *= i;
            }

            Console.WriteLine("O fatorial de {0} é {1}", numero, fatorial);
        }
    }
}