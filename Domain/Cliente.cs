using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Domain
{
    internal class Cliente : Persona
    {
        private bool pago { get; set; }
        private List<Rutina> rutinaxdia { get; set; }

        public Cliente(int id, string nombre, string apellido, int dni, string direccion, int telefono, string email, sexo genero, bool pago, List<Rutina> rutinaxdia) 
            : base(id, nombre, apellido, dni, direccion, telefono, email, genero)
        {
            this.pago = pago;
            this.rutinaxdia = rutinaxdia;
        }
    }
}
