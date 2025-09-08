using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Proyecto_Gym.Domain
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public Sexo genero { get; set; }
        public enum Sexo{
            Masculino,
            Femenino,
            Indefinido
        }

        public Persona(string nombre, string apellido, long dni, string direccion, string telefono, string email, Sexo genero) {
        }
        public Persona() { 
        }

    }
}
