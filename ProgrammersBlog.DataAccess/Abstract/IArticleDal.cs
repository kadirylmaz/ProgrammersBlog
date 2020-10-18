using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.DataAccess.Abstract
{
    public interface IArticleDal:IEntityRepository<Article>
    {

    }
}
