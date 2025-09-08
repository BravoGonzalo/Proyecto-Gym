using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    public class Cliente : Persona
    {
        public int Id { get; set; }
        public bool pago { get; set; }
        public List<Rutina> rutinaxdia { get; set; }

        public Cliente(int Id, string nombre, string apellido, long dni, string direccion, string telefono, string email, Sexo genero, bool pago, List<Rutina> rutinaxdia) 
            : base(nombre, apellido, dni, direccion, telefono, email, genero)
        {
            this.Id = Id;
            this.pago = pago;
            this.rutinaxdia = rutinaxdia;
        }
        public Cliente()
        {

        }
    }
}
