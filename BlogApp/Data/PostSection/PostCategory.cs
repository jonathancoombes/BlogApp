using BlogApp.Data.CategorySection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.PostSection
{
    public class PostCategory : Base
    {
        public virtual int PostId { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual Post Post { get; set; }

        public virtual Category Category { get; set; }

        public static void OnModelCreating(ModelBuilder builder) {
            
            builder.Entity<PostCategory>().HasOne(postCategory => postCategory.Category)
            .WithMany()
            .HasPrincipalKey(category => category.Id)
            .HasForeignKey(postCategory => postCategory.CategoryId);

            builder.Entity<PostCategory>().HasOne(postCategory => postCategory.Post)
            .WithMany(post => post.PostCategories)
            .HasPrincipalKey(post => post.Id)
            .HasForeignKey(postCategory => postCategory.PostId);
        }
    }
}
