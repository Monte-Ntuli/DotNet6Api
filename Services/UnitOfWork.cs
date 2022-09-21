using Api.Services.Interfaces;

namespace Api.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApiDbContext _context;

        public UnitOfWork(ApiDbContext context)
        {
            _context = context;
        }  
    }
}
