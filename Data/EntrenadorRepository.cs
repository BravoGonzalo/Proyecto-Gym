using Microsoft.EntityFrameworkCore;
using Proyecto_Gym.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Data
{
    public class EntrenadorRepository
    {
        private readonly AppDbContext _context;

        public EntrenadorRepository(AppDbContext context)
        {
            _context = context;
        }
        public EntrenadorRepository()
        {
            _context = new AppDbContext();
        }


        // Agregar entrenador
        public void Add(Entrenador entrenador)
        {
            _context.Entrenadores.Add(entrenador);
            _context.SaveChanges();
        }

        // Modificar entrenador
        public void Update(Entrenador entrenador)
        {
            _context.Entrenadores.Update(entrenador);
            _context.SaveChanges();
        }

        // Eliminar entrenador
        public void Delete(Entrenador entrenador)
        {
            _context.Entrenadores.Remove(entrenador);
            _context.SaveChanges();
        }

        // Traer entrenador por Id
        public Entrenador GetById(int id)
        {
            return _context.Entrenadores.FirstOrDefault(e => e.Id == id);
        }

        // Traer todos los entrenadores
        public List<Entrenador> GetAll()
        {
            return _context.Entrenadores.ToList();
        }
    }
}
