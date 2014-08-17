using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Extensions.NamedScope;
using NinjectStartupSetup.Utils.Data;
using NinjectStartupSetup.Utils.Repositories.UserRepo;

namespace NinjectStartupSetup.Utils
{
    public class DatabaseModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InCallScope();
            Bind<IDbConfiguration>().To<DbConfiguration>();
            Bind<IUserRepo>().To<UserRepo>().InRequestScope();
        }
    }
}