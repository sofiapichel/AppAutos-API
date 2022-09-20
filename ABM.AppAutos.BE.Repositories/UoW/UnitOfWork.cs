using ABM.AppAutos.BE.Repositories.Interfaces;
using AppAutos.DataAccess;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Dependencias

        private readonly VehiculoDbContext _context;

        public IColorRepository Color { get; }
        public ICombustibleRepository Combustible{ get; }
        public IEstadoRepository Estado { get; }
        public IMarcaRepository Marca{ get; }
        public IPaisRepository Pais { get; }
        public ISeguroRepository Seguro{ get; }
        public ITipoRepository Tipo { get; }
        public IVehiculoRepository Vehiculo{ get; }

        #endregion

        #region Constructor
        public UnitOfWork(
            VehiculoDbContext context,
            IColorRepository ColorRepository,
            ICombustibleRepository CombustibleRepository,
            IEstadoRepository EstadoRepository,
            IMarcaRepository MarcaRepository,
            IPaisRepository PaisRepository,
            ISeguroRepository SeguroRepository,
            ITipoRepository TipoRepository,
            IVehiculoRepository VehiculoRepository

            )
        {
            this._context = context;

            this.Color = ColorRepository;
            this.Combustible = CombustibleRepository;
            this.Estado = EstadoRepository;
            this.Marca = MarcaRepository;
            this.Pais = PaisRepository;
            this.Seguro = SeguroRepository;
            this.Tipo = TipoRepository;
            this.Vehiculo = VehiculoRepository;
           
        }
        #endregion

        #region Metodos

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        #endregion
    }
}
