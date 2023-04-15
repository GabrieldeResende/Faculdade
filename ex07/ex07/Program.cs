using System;


namespace Course {
    class program {
        static void Main(string[] args) {

            Console.WriteLine("digite o dia da validade: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o mes da validade: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o ano da validade: ");
            int ano = int.Parse(Console.ReadLine());

            if ((dia <= 30) && (mes <= 12) && (ano > 1900 || ano < 2999)) {
                Console.WriteLine("dentro do prazo de validade");

            } else {
                Console.WriteLine("Vencido");
            }
        }
    }
}