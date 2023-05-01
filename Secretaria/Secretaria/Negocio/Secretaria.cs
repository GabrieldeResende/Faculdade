using Secretaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Negocio {
    public class SecretariaBussiness : ISecretaria {

        static List<Aluno> ListaAlunos;

        public SecretariaBussiness() {
            ListaAlunos= new List<Aluno>();
        }
        public void Add(Aluno aluno) {
            ListaAlunos.Add(aluno);
        }

        public void Edit(Aluno alunoAlterado) {
            var alunoOriginal = ListaAlunos.FirstOrDefault(x => x.Matricula == alunoAlterado.Matricula);
            if (alunoOriginal != null) {
                alunoOriginal.Nome = alunoAlterado.Nome;
                alunoOriginal.Curso= alunoAlterado.Curso;
                alunoOriginal.Notas = alunoAlterado.Notas;
            }
        }

        public List<Aluno> List() {
            return ListaAlunos;
        }

        public void Remove(string matricula) {
            var aluno = ListaAlunos.FirstOrDefault(x => x.Matricula == matricula);
            ListaAlunos.Remove(aluno);
        }
    }
}
