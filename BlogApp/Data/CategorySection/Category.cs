using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data.CategorySection
{
    public class Category : Base
    {
        public virtual string Name { get; set; }

        public virtual bool Enabled { get; set; }
    }
}
