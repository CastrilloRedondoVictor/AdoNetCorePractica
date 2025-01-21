using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Models
{
    public class Plantilla
    {
        private int HospitalCod { get; set; }
        private int SalaCod { get; set; }
        private int EmpleadoNo { get; set; }
        private string Apellido { get; set; }
        private string Funcion { get; set; }
        private string T { get; set; }
        private int Salario { get; set; }

        public Plantilla(int hospitalCod, int salaCod, int empleadoNo, string apellido, string funcion, string t, int salario) { 
            this.HospitalCod = hospitalCod;
            this.SalaCod = salaCod;
            this.EmpleadoNo = empleadoNo;
            this.Apellido = apellido;
            this.Funcion = funcion;
            this.T = t;
            this.Salario = salario;
        }






    }
}
