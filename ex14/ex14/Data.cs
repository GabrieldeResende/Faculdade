using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14 {
    internal class Data {
        public int dia;
        public int mes;
        public int ano;
        public int hora;
        public int minuto;
        public int segundo;

        public const int FORMATO_12H = 12;
        public const int FORMATO_24H = 24;

        public Data(int dia, int mes, int ano) {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo)
            : this(dia, mes, ano) {
            if (hora < 0 || hora > 23) ;
            {
                throw new ArgumentException("Hora deve estar entre 0 e 23.");
            }

            this.hora = hora;

            if (minuto < 0 || minuto > 59) {
                throw new ArgumentException("Minuto deve estar entre 0 e 59.");
            }

            this.minuto = minuto;

            if (segundo < 0 || segundo > 59) {
                throw new ArgumentException("Segundo deve estar entre 0 e 59.");
            }

            this.segundo = segundo;
        }

        public int Dia {
            get { return dia; }
        }

        public int Mes {
            get { return mes; }
        }

        public int Ano {
            get { return ano; }
        }

        public int? Hora {
            get { return hora; }
        }

        public int? Minuto {
            get { return minuto; }
        }

        public int? Segundo {
            get { return segundo; }
        }

        public void Imprimir(int formatoHora = FORMATO_24H) {
            if (hora == null || minuto == null || segundo == null) {
                Console.WriteLine("{0}/{1}/{2}", dia, mes, ano);
            }
            else {
                string formato = formatoHora == FORMATO_12H ? "hh:mm:ss tt" : "HH:mm:ss";
                DateTime dataHora = new DateTime(ano, mes, dia, hora, minuto, segundo);
                Console.WriteLine(dataHora.ToString(formato));
            }
        }
    }
}
