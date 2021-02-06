using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.PostSection
{
    public class Post : Base
    {

        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual bool Enabled{ get; set; }
        public virtual DateTimeOffset? Published { get; set; }
        public virtual ICollection<PostCategory> PostCategories { get; set; }

    }
}
