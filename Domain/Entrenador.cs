using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    public class Entrenador : Persona
    {
        public int Id { get; set; }
        public List<Cliente> clientes { get; set; }
        public Entrenador(int Id, string nombre, string apellido, int dni, string direccion, int telefono, string email, sexo genero, int id_Entrenador, List<Cliente> clientes) 
            : base(nombre, apellido, dni, direccion, telefono, email, genero)
        {
            this.Id = Id;
            this.clientes = clientes;
        }
        public Entrenador()
        {

        }
    }
}
