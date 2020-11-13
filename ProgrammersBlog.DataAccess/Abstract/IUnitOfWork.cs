using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.DataAccess.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IArticleDal Articles { get; }
        ICategoryDal Categories { get;  }
        ICommentDal Comments { get; }
        IRoleDal Roles { get;  }
        IUserDal Users { get; } // _unitOfWork.Categories.AddAsync();
        Task<int> SaveAsync();

    }
}
