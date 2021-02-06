using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.CategorySection
{
    public partial interface ICategoryService
    {
        Task<Category> GetAsync(int id);

        Task<IEnumerable<Category>> GetAllAsync();
    }
}
