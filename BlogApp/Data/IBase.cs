using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
   public partial interface IBase
    {

        int Id { get; set; }

        DateTimeOffset Created { get; set; }

        DateTimeOffset? LastUpdated { get; set; }

        DateTimeOffset? Deleted { get; set; }

       
    }
}
