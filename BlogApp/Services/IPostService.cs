using BlogApp.Data.PostSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Services
{
    public partial interface IPostService
    {
        Task<Post> GetAsync(int id);

        Task<IEnumerable<Post>> GetAllAsync(int? categoryId = null);
    }
}
