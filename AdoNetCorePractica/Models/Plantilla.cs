using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Models
{
    public class Plantilla
    {
        private string Apellido { get; set; }
        private string Funcion { get; set; }
        private int Salario { get; set; }

        public Plantilla(string apellido, string funcion, int salario)
        {
            this.Apellido = apellido;
            this.Funcion = funcion;
            this.Salario = salario;
        }

        public override string ToString()
        {
            return $"{Apellido} - {Funcion} - {Salario}";
        }
    }
}
