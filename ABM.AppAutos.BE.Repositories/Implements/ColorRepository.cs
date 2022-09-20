using ABM.AppAutos.BE.Repositories.Generic;
using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using AppAutos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.Implements
{
    public class ColorRepository : GenericRepository<Color>, IColorRepository
    {
        //private readonly VehiculoDbContext _context;

        public ColorRepository(VehiculoDbContext context) : base(context)
        {
            //_context = context;
        }

        
    }
}
