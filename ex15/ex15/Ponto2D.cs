using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15 {
    public class Ponto2D {
            public double x;
            public double y;

            public Ponto2D(double x, double y) {
                this.x = x;
                this.y = y;
            }

            public void Imprimir() {
                Console.WriteLine("Coordenadas do Ponto2D: ({0}, {1})", x, y);
            }
    }
    public class Ponto3D : Ponto2D {
        public double z;

        public Ponto3D(double x, double y, double z) : base(x, y) {
            this.z = z;
        }

        public new void Imprimir() {
            Console.WriteLine("Coordenadas do Ponto3D: ({0}, {1}, {2})", base.x, base.y, z);
        }
    }
}
