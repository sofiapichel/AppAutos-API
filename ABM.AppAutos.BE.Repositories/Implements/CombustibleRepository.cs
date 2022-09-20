using ABM.AppAutos.BE.Repositories.Generic;
using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using AppAutos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.Implements
{
    public class CombustibleRepository : GenericRepository<Combustible>, ICombustibleRepository
    {
        //private readonly VehiculoDbContext _context;

        public CombustibleRepository(VehiculoDbContext context) : base(context)
        {
            //_context = context;
        }

       
    }
}
