using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Proyecto_Gym.Domain
{
    internal class Persona
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }
        private string direccion { get; set; }
        private int telefono { get; set; }
        private string email { get; set; }
        public sexo genero { get; set; }
        public enum sexo{
            Masculino,
            Femenino,
            Indefinido
        }

        public Persona(int id, string nombre, string apellido, int dni, string direccion, int telefono, string email, sexo genero) { }
    }
}
