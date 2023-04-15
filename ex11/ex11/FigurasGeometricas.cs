using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex11 {
    internal class FigurasGeometricas {


        public class Triangulo {
            public double baseTriangulo { get; set; }
            public double altura { get; set; }

            public Triangulo(double baseTriangulo, double altura) {
                this.baseTriangulo= baseTriangulo;
                this.altura= altura;
            }
            public double CalcularArea() {
                return (baseTriangulo * altura) / 2;
            }
        }

        public class Quadrado {
            public double lado { get; set; }

            public Quadrado(double lado) {
                this.lado = lado;
            }

            public double CalcularArea() {
                return lado * lado;
            }
        }

        public class Circunferencia {
            private double raio;

            public Circunferencia(double raio) {
                this.raio = raio;
            }

            public double CalcularArea() {
                return Math.PI * raio * raio;
            }
        }

        public class Trapezio {
            public double baseMaior { get; set; }
            public double baseMenor { get; set; }
            public double altura { get; set; }

            public Trapezio(double baseMarior, double baseMenor, double altura) {
                this.baseMaior = baseMaior;
                this.baseMenor = baseMenor;
                this.altura = altura;
            }

            public double CalcularArea() {
                return (baseMaior * baseMenor) / 2 * altura;
            }
        }
    }
}
