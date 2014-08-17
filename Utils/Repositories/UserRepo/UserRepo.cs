using NinjectStartupSetup.Utils.Data;
using System.Collections.Generic;
using System.Linq;
using NinjectStartupSetup.Models;

namespace NinjectStartupSetup.Utils.Repositories.UserRepo
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        public UserRepo(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public List<User> GetAll()
        {
            return this.unitOfWork.DbContext.Set<User>().ToList();
        }
    }
}