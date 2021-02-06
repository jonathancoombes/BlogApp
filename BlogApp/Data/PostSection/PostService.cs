using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.PostSection
{
    public partial class PostService : IPostService
    {

        protected readonly BlogAppDbContext _context;

        public PostService([NotNull] BlogAppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<Post> GetAsync(int id)
        {
            return await _context.Set<Post>().EnabledPosts().FirstOrDefaultAsync(post => post.Id == id);
        }

        public virtual async Task<IEnumerable<Post>> GetAllAsync(int? categoryId = null)
        {
            var query = _context.Set<Post>().Include(post => post.PostCategories).ThenInclude(postCategory => postCategory.Category).AsQueryable().EnabledPosts();

            if (!categoryId.HasValue)
            {
                return await query.ToListAsync();
            }

            return await query.Where(post => post.PostCategories.Any(postCategory => postCategory.CategoryId == categoryId 
            && !postCategory.Deleted.HasValue 
            && postCategory.Category != null 
            && postCategory.Category.Enabled 
            && !postCategory.Category.Deleted.HasValue)).ToListAsync();
        }
    }

    public static class PostServiceHelpers
    {
        public static IQueryable<Post> EnabledPosts(this IQueryable<Post> query)
        {
            return query.Where(post => post.Enabled 
            && post.Published.HasValue 
            && !post.Deleted.HasValue);
        }








    }
}
