using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10 {
    public class Fracao {
        private int numerador;
        private int denominador;

        public Fracao(int numerador, int denominador) {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public Fracao Multiplica(Fracao outraFracao) {
            int novoNumerador = this.numerador * outraFracao.numerador;
            int novoDenominador = this.denominador * outraFracao.denominador;
            return new Fracao(novoNumerador, novoDenominador);
        }
    }
}
