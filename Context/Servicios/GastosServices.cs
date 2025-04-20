using FinanzasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.Context.Servicios
{
    public class GastosServices : IGastosService
    {

        private readonly FinanzasAppContext _context;
        public GastosServices(FinanzasAppContext  context)
        {
            _context = context;
        }

        public async Task Add(Gastos gastos)
        {
            _context.Gastos.Add(gastos);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Gastos>> GetAll()
        {
            var expenses = await _context.Gastos.ToListAsync();
            return expenses;
        }
    }
}
