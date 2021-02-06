using BlogApp.Data.CategorySection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Services
{
    public partial interface ICategoryService
    {
        Task<Category> GetAsync(int id);

        Task<IEnumerable<Category>> GetAllAsync();
    }
}
