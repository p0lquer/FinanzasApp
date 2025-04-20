using FinanzasApp.Models;

namespace FinanzasApp.Context.Servicios
{
    public interface IGastosService
    {
        Task<IEnumerable<Gastos>> GetAll();

        Task Add(Gastos gastos);
    }
}
