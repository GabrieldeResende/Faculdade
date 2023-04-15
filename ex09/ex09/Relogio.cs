using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09 {
    internal class Relogio {
        class Ponteiro {
            private int posicao;

            public Ponteiro(int posicao) {
                this.posicao = posicao;
            }

            public int GetPosicao() {
                return posicao;
            }

            public void SetPosicao(int posicao) {
                this.posicao = posicao;
            }
        }

        private Ponteiro ponteiroHora;
        private Ponteiro ponteiroMinuto;
        private Ponteiro ponteiroSegundo;

        public Relogio() {
            ponteiroHora = new Ponteiro(1);
            ponteiroMinuto = new Ponteiro(1);
            ponteiroSegundo = new Ponteiro(1);
        }

        public void AcertarRelogio(int hora, int minuto, int segundo) {
            ponteiroHora.SetPosicao(hora);
            ponteiroMinuto.SetPosicao(minuto);
            ponteiroSegundo.SetPosicao(segundo);
        }

        public int LerHora() {
            return ponteiroHora.GetPosicao();
        }

        public int LerMinuto() {
            return ponteiroMinuto.GetPosicao();
        }

        public int LerSegundo() {
            return ponteiroSegundo.GetPosicao();
        }
    }
}