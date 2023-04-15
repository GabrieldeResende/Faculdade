using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16 {
    internal class Exercicio {
        public class Porta : ICloneable {
            public double altura;
            public double largura;
            public bool aberta;

            public Porta(double altura, double largura, bool aberta) {
                this.altura = altura;
                this.largura = largura;
                this.aberta = aberta;
            }

            public void Abrir() {
                aberta = true;
            }

            public void Fechar() {
                aberta = false;
            }

            public double Altura {
                get { return altura; }
            }

            public double Largura {
                get { return largura; }
            }

            public bool Aberta {
                get { return aberta; }
            }

            public object Clone() {
                return new Porta(altura, largura, aberta);
            }
        }
    }
}
