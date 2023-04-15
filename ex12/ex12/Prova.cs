using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12 {
    public class Prova {
        public double Parte1 { get; set; }
        public double Parte2 { get; set; }

        public double CalcularMedia() {
            return (Parte1 + Parte2) / 2.0;
        }
    }

    // Classe para representar um Aluno, que realizou duas provas
    public class Aluno {
        public string Nome { get; set; }
        public Prova Prova1 { get; set; }
        public Prova Prova2 { get; set; }

        public double CalcularMedia() {
            return (Prova1.CalcularMedia() + Prova2.CalcularMedia()) / 2.0;
        }
    }

    // Classe para representar uma Turma, composta por três alunos
    public class Turma {
        public Aluno Aluno1 { get; set; }
        public Aluno Aluno2 { get; set; }
        public Aluno Aluno3 { get; set; }

        public double CalcularMedia() {
            return (Aluno1.CalcularMedia() + Aluno2.CalcularMedia() + Aluno3.CalcularMedia()) / 3.0;
        }
    }
}
