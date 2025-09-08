using Proyecto_Gym.Data;
using Proyecto_Gym.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Business
{
    public class EntrenadorService
    {
        private readonly EntrenadorRepository _repo;

        public EntrenadorService(EntrenadorRepository repo)
        {
            _repo = repo;
        }

        public EntrenadorService()
        {
            _repo = new EntrenadorRepository();
        }

        // Crear entrenador
        public void CrearEntrenador(Entrenador entrenador)
        {
            if (entrenador == null)
                throw new ArgumentNullException("El entrenador no puede ser nulo");

            if (string.IsNullOrEmpty(entrenador.nombre))
                throw new Exception("El nombre es obligatorio");

            if (entrenador.clientes == null)
                entrenador.clientes = new List<Cliente>();

            _repo.Add(entrenador);
        }

        // Modificar entrenador
        public void ModificarEntrenador(Entrenador entrenador)
        {
            var existente = _repo.GetById(entrenador.Id);
            if (existente == null)
                throw new Exception("Entrenador no existe");

            existente.nombre = entrenador.nombre;
            existente.apellido = entrenador.apellido;
            existente.dni = entrenador.dni;
            existente.direccion = entrenador.direccion;
            existente.telefono = entrenador.telefono;
            existente.email = entrenador.email;
            existente.genero = entrenador.genero;
            existente.clientes = entrenador.clientes;

            _repo.Update(existente);
        }

        // Eliminar entrenador
        public void EliminarEntrenador(int id)
        {
            var entrenador = _repo.GetById(id);
            if (entrenador == null)
                throw new Exception("Entrenador no existe");

            _repo.Delete(entrenador);
        }

        // Traer todos los entrenadores
        public List<Entrenador> TraerTodos()
        {
            return _repo.GetAll();
        }

        // Traer entrenador por Id
        public Entrenador TraerPorId(int id)
        {
            return _repo.GetById(id);
        }
    }
}
    

