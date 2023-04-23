using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;

        public SeedDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVillasAsync();
        }

        public async Task CheckVillasAsync()
        {
            if(!_context.Villas.Any())
            {
                _context.Villas.Add(
                    new Villa
                    {
                        Nombre = "Villa Real",
                        Detalle = "Datalle de la Villa 1...",
                        ImageUrl = "",
                        Ocupantes = 5,
                        MetrosCuadrados = 50,
                        Tarifa = 200,
                        Amenidad = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now
                    });

                _context.Villas.Add(
                    new Villa
                    {
                        Nombre = "Premiun Villa a la Piscina",
                        Detalle = "Datalle de la Villa 2...",
                        ImageUrl = "",
                        Ocupantes = 4,
                        MetrosCuadrados = 40,
                        Tarifa = 150,
                        Amenidad = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
