using BlogApp.Data;
using BlogApp.Data.CategorySection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Services
{
    public partial class CategoryService : ICategoryService
    {

            protected readonly BlogAppDbContext _context;

            public CategoryService([NotNull] BlogAppDbContext context)
            {
                _context = context;
            }

            public virtual async Task<Category> GetAsync(int id)
            {
                return await _context.Set<Category>().EnabledCategories().FirstOrDefaultAsync(post => post.Id == id);
            }

            public virtual async Task<IEnumerable<Category>> GetAllAsync()
            {
                return await _context.Set<Category>().EnabledCategories().ToListAsync();
            }
        }

        public static class CategoryServiceHelpers
        {
            public static IQueryable<Category> EnabledCategories(this IQueryable<Category> query)
            {
                return query.Where(category => category.Enabled && !category.Deleted.HasValue);
            }
        }

}
