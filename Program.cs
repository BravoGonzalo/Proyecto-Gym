using Proyecto_Gym.Business;
using Proyecto_Gym.Data;

namespace Proyecto_Gym
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Crear instancias de los servicios requeridos por el constructor de Form1
            var dbContext = new AppDbContext(); // Instancia de AppDbContext
            var clienteRepository = new ClienteRepository(dbContext); // Instancia de ClienteRepository
            var clienteService = new ClienteService(clienteRepository); // Pasa el repo al constructor
            var entrenadorRepository = new EntrenadorRepository(dbContext); // Pasa el contexto al constructor
            var entrenadorService = new EntrenadorService(entrenadorRepository); // Pasa el repo al constructor

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(clienteService, entrenadorService));
        }
    }
}