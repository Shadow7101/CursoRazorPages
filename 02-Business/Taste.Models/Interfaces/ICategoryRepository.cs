using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using Taste.Models.Entities;

namespace Taste.Models.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<SelectListItem>> GetCategoryListForDropDown();

        Task Update(Category entity);
    }
}
