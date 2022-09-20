using ABM.AppAutos.BE.Repositories.Generic;
using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using AppAutos.Models;

namespace ABM.AppAutos.BE.Repositories.Implements
{
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        //private readonly VehiculoDbContext _context;

        public PaisRepository(VehiculoDbContext context) : base(context)
        {
            //_context = context;
        }

        
    }
}
