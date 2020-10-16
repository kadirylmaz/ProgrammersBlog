using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
        //public override string CreatedByName { get; set; } = "Admin";

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
