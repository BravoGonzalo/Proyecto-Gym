using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    internal class Rutina
    {
        private String nombre { get; set; }
        private List<Ejercicio> ejercicios { get; set; }
        public Rutina(String nombre, List<Ejercicio> ejercicios)
        {
            this.nombre = nombre;
            this.ejercicios = ejercicios;
        }
    }
}
