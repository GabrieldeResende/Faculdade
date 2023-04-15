using System;

class Program {
    static void Main(string[] args) {
        int num1 = 0, num2 = 1, proximo;
        Console.Write("{0} {1}", num1, num2);

        for (int i = 3; i <= 15; i++) {
            proximo = num2;
            num2 += num1;
            num1 = proximo;
            Console.Write(" {0}", proximo);
        }
    }
}