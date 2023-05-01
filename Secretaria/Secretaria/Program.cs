using Secretaria.Entidades;
using Secretaria.Negocio;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Secretaria {
    class Program {

        ISecretaria _secretaria = new SecretariaBussiness();
        static void Main(string[] args) {
            
            Program program = new Program();
            int selecao = 0;

            while (selecao != 6) {
                Console.WriteLine("Selecione uma Opção");
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Adicionar Notas");
                Console.WriteLine("3 - Editar Aluno");
                Console.WriteLine("4 - Listar alunos");
                Console.WriteLine("5 - Remover Aluno");
                Console.WriteLine("6 - Sair");
                selecao = int.Parse(Console.ReadLine());
                switch (selecao) {
                    case 1:
                        program.AddAluno();
                        break;
                    case 2:
                        program.AddNotas();
                        break;
                    case 3:
                        program.Edit();
                        break;
                    case 4:
                        program.ListarAlunos();
                        break;
                    case 5:
                        program.Remove();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Pausa pro café");
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção Invalida");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
        private void ListarAlunos() {
            foreach (var aluno in _secretaria.List()) {
                Console.WriteLine($"aluno: {aluno.Nome} \nmatricula: {aluno.Matricula} \nCurso: {aluno.Curso.NomeCurso} \ncodigo do Curso: {aluno.Curso.CodigoCurso}");
                foreach(var nota in aluno.Notas) {
                    Console.WriteLine($"Media: {nota.Valor}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private void AddAluno() {
            var aluno = new Aluno();
            Console.WriteLine("digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua matricula: ");
            aluno.Matricula = Console.ReadLine();

            Console.WriteLine("Digite o codigo do Curso: ");
            aluno.Curso.CodigoCurso = Console.ReadLine();

            Console.WriteLine("Digite o nome do Curso: ");
            aluno.Curso.NomeCurso = Console.ReadLine();
            
            _secretaria.Add(aluno);
            AddNotas(aluno.Matricula);
        }

        private void AddNotas(string matricula = null) {
            if (string.IsNullOrEmpty(matricula)) {
                Console.WriteLine("Digite a matricula: ");
                matricula = Console.ReadLine();
            }
            Console.WriteLine("Digite a NP1");
            var NP1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a NP2");
            var NP2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o PIM");
            var PIM = double.Parse(Console.ReadLine());

            var media = (NP1 * 4 + PIM * 2 + NP2 * 4) / 10;
            var aluno = _secretaria.List().FirstOrDefault(x => x.Matricula == matricula);

            if (aluno != null) {
                aluno.Notas.Add(new Nota { Nome = "notaFinal", Valor = media });
                _secretaria.Edit(aluno);
            }

            Console.WriteLine("Media total: " + media);
            Console.WriteLine(media >= 5 ? "Aprovado" : "Reprovado");
        }

        private void Edit() {

            Console.WriteLine("Digite a matricula: ");
            string matricula = Console.ReadLine();
            var aluno = _secretaria.List().FirstOrDefault(x => x.Matricula == matricula);

            if (aluno != null) {
                Console.WriteLine("digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite sua matricula: ");
                aluno.Matricula = Console.ReadLine();

                Console.WriteLine("Digite o codigo do Curso: ");
                aluno.Curso.CodigoCurso = Console.ReadLine();

                Console.WriteLine("Digite o nome do Curso: ");
                aluno.Curso.NomeCurso = Console.ReadLine();

                _secretaria.Edit(aluno);
            } else {
                Console.WriteLine("Aluno não encontrado!!");
            }
        }
        private void Remove() {
            Console.WriteLine("Digite a matricula: ");
            string matricula = Console.ReadLine();
            _secretaria.Remove(matricula);
        }
    }
}
