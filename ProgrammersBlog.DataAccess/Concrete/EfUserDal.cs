using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.DataAccess.Concrete
{
    public class EfUserDal:EfEntityRepositoryBase<User>,IUserDal
    {
        public EfUserDal(DbContext context):base(context)
        {

        }
    }
}
