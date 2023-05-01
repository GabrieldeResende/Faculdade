using Secretaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Negocio {
    public interface ISecretaria {
        void Add(Aluno aluno);
        void Remove(string matricula);
        List<Aluno> List();
        void Edit(Aluno alunoAlterado);
    }
}
