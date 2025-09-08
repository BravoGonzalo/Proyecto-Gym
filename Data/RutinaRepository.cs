using Microsoft.EntityFrameworkCore;
using Proyecto_Gym.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym.Data
{
    public class RutinaRepository
    {
        private readonly AppDbContext _context;

        public RutinaRepository(AppDbContext context)
        {
            _context = context;
        }

        // Agregar rutina
        public void Add(Rutina rutina)
        {
            _context.Rutinas.Add(rutina);
            _context.SaveChanges();
        }

        // Modificar rutina
        public void Update(Rutina rutina)
        {
            _context.Rutinas.Update(rutina);
            _context.SaveChanges();
        }

        // Eliminar rutina
        public void Delete(Rutina rutina)
        {
            _context.Rutinas.Remove(rutina);
            _context.SaveChanges();
        }

        // Traer rutina por Id
        public Rutina GetById(int id)
        {
            return _context.Rutinas
                .Include(r => r.ejercicios) // Incluimos la lista de ejercicios
                .FirstOrDefault(r => r.Id == id);
        }

        // Traer todas las rutinas
        public List<Rutina> GetAll()
        {
            return _context.Rutinas
                .Include(r => r.ejercicios) // Incluimos la lista de ejercicios
                .ToList();
        }
    }
}
