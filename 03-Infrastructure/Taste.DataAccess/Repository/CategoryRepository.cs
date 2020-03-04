using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taste.Models.Entities;
using Taste.Models.Interfaces;

namespace Taste.DataAccess.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetCategoryListForDropDown()
        {
            return await _db.Category.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }).ToListAsync();
        }

        public async Task Update(Category entity)
        {
            var model = await _db.Category.FirstOrDefaultAsync(x => x.Id == entity.Id);

            model.Name = entity.Name;
            model.DisplayOrder = entity.DisplayOrder;

            await _db.SaveChangesAsync();
        }
    }
}
