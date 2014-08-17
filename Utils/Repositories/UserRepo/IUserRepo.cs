using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjectStartupSetup.Models;

namespace NinjectStartupSetup.Utils.Repositories.UserRepo
{
    public interface IUserRepo : IRepository<User>
    {
        List<User> GetAll();
    }
}