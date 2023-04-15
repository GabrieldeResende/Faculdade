using System;

class Program {
    static void Main(string[] args) {
        int contador = 0;
        double somaNotas = 0;
        double nota;

        do {
            Console.Write("Digite a nota (ou -1 para sair): ");
            nota = double.Parse(Console.ReadLine());

            if (nota != -1) {
                somaNotas += nota;
                contador++;
            }
        } while (nota != -1);

        if (contador > 0) {
            double media = somaNotas / contador;
            Console.WriteLine("A média das notas é {0:F2}", media);
        }
    }
}