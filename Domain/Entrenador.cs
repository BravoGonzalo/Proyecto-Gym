using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    internal class Entrenador : Persona
    {
        private int id_Entrenador { get; set; }
        private List<Cliente> clientes { get; set; }
        public Entrenador(int id, string nombre, string apellido, int dni, string direccion, int telefono, string email, sexo genero, int id_Entrenador, List<Cliente> clientes) 
            : base(id, nombre, apellido, dni, direccion, telefono, email, genero)
        {
            this.id_Entrenador = id_Entrenador;
            this.clientes = clientes;
        }
    }
}
