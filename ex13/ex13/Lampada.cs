using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13 {
    internal class Lampada {
        private bool ligada;

        public Lampada(bool estadoInicial) {
            ligada = estadoInicial;
        }

        public void Ligar() {
            ligada = true;
        }

        public void Desligar() {
            ligada = false;
        }

        public void Imprimir() {
            Console.WriteLine(ligada ? "Lâmpada ligada" : "Lâmpada desligada");
        }
    }
}
