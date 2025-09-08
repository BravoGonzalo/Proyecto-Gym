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
        public int dni { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public sexo genero { get; set; }
        public enum sexo{
            Masculino,
            Femenino,
            Indefinido
        }

        public Persona(string nombre, string apellido, int dni, string direccion, int telefono, string email, sexo genero) {
        }
        public Persona() { 
        }

    }
}
