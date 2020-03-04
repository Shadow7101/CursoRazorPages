using System;
using System.Threading.Tasks;

namespace Taste.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        Task Save();
    }
}
