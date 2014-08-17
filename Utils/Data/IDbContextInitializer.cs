using System.Data.Entity;

namespace NinjectStartupSetup.Utils.Data
{
    public interface IDbContextInitializer
    {
        void InitializeContext(DbContext context);
    }
}
