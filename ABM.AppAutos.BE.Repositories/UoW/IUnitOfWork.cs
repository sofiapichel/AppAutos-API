using ABM.AppAutos.BE.Repositories.Interfaces;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.UoW
{
    public interface IUnitOfWork
    {
        public IColorRepository Color { get; }
        public ICombustibleRepository Combustible { get; }
        public IEstadoRepository Estado { get; }
        public IMarcaRepository Marca { get; }
        public IPaisRepository Pais { get; }
        public ISeguroRepository Seguro { get; }
        public ITipoRepository Tipo { get; }
        public IVehiculoRepository Vehiculo { get; }

        Task SaveChanges();
    }
}
