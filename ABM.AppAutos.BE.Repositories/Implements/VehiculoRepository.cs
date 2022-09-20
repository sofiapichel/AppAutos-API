using ABM.AppAutos.BE.Repositories.Generic;
using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using AppAutos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.Implements
{
    //TODO HACER EL GENERICO DE VEHICULO.
    public class VehiculoRepository : GenericRepository<Vehiculo>,IVehiculoRepository
    {
        //private readonly VehiculoDbContext _context;

        public VehiculoRepository(VehiculoDbContext context) : base(context)
        {
            //_context = context;
        }

        public new async Task<IEnumerable<Vehiculo>> GetAll()
        {
            return await _context.Vehiculos
                                .Include(x => x.Marca)
                                .Include(x => x.Pais)
                                .Include(x => x.Estado)
                                .Include(x => x.Color)
                                .Include(x => x.Tipo)
                                .Include(x => x.Combustible)
                                .Include(x => x.Seguro).
                                ToListAsync();
        }

        public new async Task<Vehiculo> GetById(int id)
        {
            return await _context.Vehiculos

                                .Include(x => x.Marca)
                                .Include(x => x.Pais)
                                .Include(x => x.Estado)
                                .Include(x => x.Color)
                                .Include(x => x.Tipo)
                                .Include(x => x.Combustible)
                                .Include(x => x.Seguro)
                                .FirstOrDefaultAsync(x => x.Id == id);
        }

      
    }
}
