using System;


namespace Course {
    class program {
        static void Main(string[] args) {

            #region a. Imprima todos os números de 10 a 25. 
            var atividadeA = Enumerable.Range(10, 16);
            foreach ( var item in atividadeA) {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region b. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).
            var atividadeB = Enumerable.Range(0, 100).Where(x => x % 2 == 1).Sum();
            Console.WriteLine(atividadeB);
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region c. Começando em 0, imprima os números seguintes, enquanto a soma dos números já impressos for menor que 100.
            var atividadeC = Enumerable.Range(0, 100);
            int soma = 0;
            foreach (var item in atividadeC) {
                soma += item;
                if(soma <= 100) {
                    Console.WriteLine(soma);
                }
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region d. Imprima a tabuada do 9 (até o décimo valor).
            int numero = 9;

            for (int i = 1; i <= 10; i++) {
                int resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }
            #endregion
        }
    }
}