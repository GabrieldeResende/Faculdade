using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Entidades
{
    public class Aluno : IComparable<Aluno>
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public Curso Curso { get; set; }
        public List<Nota> Notas { get; set; }

        public Aluno() {
            Notas = new List<Nota>();
            Curso = new Curso();
        }

        public int CompareTo(Aluno? other) {
            throw new NotImplementedException();
        }
    }
}
