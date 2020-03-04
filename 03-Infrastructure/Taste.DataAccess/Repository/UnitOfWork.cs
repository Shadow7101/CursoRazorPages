using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taste.Models.Interfaces;

namespace Taste.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
            Category = new CategoryRepository(context);
        }

        public ICategoryRepository Category { get; private set; }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
