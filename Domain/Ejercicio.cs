using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    internal class Ejercicio
    {
        private int series { get; set; }
        private int repeticiones { get; set; }
        public EnumEjercicio.nombreEjercicio nombreEJ { get; set; }

        public Ejercicio(int series, int repeticiones, EnumEjercicio.nombreEjercicio nombreEJ)
        {
            this.series = series;
            this.repeticiones = repeticiones;
            this.nombreEJ = nombreEJ;
        }
    }
}
