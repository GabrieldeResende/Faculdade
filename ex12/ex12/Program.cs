using ex12;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Turma turma = new Turma();
            turma.Aluno1 = new Aluno() { Nome = "Aluno 1", Prova1 = new Prova() { Parte1 = 4.0, Parte2 = 2.5 }, Prova2 = new Prova() { Parte1 = 1.0, Parte2 = 7.0 } };
            turma.Aluno2 = new Aluno() { Nome = "Aluno 2", Prova1 = new Prova() { Parte1 = 6.5, Parte2 = 3.5 }, Prova2 = new Prova() { Parte1 = 0.0, Parte2 = 3.0 } };
            turma.Aluno3 = new Aluno() { Nome = "Aluno 3", Prova1 = new Prova() { Parte1 = 5.0, Parte2 = 4.0 }, Prova2 = new Prova() { Parte1 = 6.0, Parte2 = 1.5 } };

            // Mostra a média de cada aluno e a média geral da turma
            Console.WriteLine($"Média do {turma.Aluno1.Nome}: {turma.Aluno1.CalcularMedia()}");
            Console.WriteLine($"Média do {turma.Aluno2.Nome}: {turma.Aluno2.CalcularMedia()}");
            Console.WriteLine($"Média do {turma.Aluno3.Nome}: {turma.Aluno3.CalcularMedia()}");
            Console.WriteLine($"Média geral da turma: {turma.CalcularMedia()}");


        }
    }
}