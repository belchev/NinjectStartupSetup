using NinjectStartupSetup.Utils.Data;
using NinjectStartupSetup.Utils.Repositories.UserRepo;
using System;
using System.Web.Mvc;
using NinjectStartupSetup.Models;

namespace NinjectStartupSetup.Controllers
{
    public class UserController : Controller
    {
        private IUserRepo userRepo;
        private IUnitOfWork unitOfWork;

        public UserController(IUnitOfWork unitOfWork, IUserRepo userRepo)
        {
            this.userRepo = userRepo;
            this.unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            using (var transaction = this.unitOfWork.BeginTransaction())
            {
                User u = new User();
                u.Login = "test" + Guid.NewGuid();
                u.Lang = 1;
                u.IsPublic = true;

                this.unitOfWork.DbContext.Set<User>().Add(u);

                this.unitOfWork.Save();

                transaction.Commit();
            }

            var t = this.userRepo.GetAll();

            return View();
        }
    }
}