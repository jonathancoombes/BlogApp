using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.PostSection
{
    public partial interface IPostService
    {
        Task<Post> GetAsync(int id);

        Task<IEnumerable<Post>> GetAllAsync(int? categoryId = null);
    }
}
