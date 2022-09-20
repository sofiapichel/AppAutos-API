using ABM.AppAutos.BE.Repositories.Generic;
using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using AppAutos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ABM.AppAutos.BE.Repositories.Implements
{
     public class MarcaRepository : GenericRepository<Marca>, IMarcaRepository
     {
        //private readonly VehiculoDbContext _context;

        public MarcaRepository(VehiculoDbContext context) : base(context)
        {
            //_context = context;
        }

        
     }
}
