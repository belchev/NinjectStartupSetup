﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace NinjectStartupSetup.Utils.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        TEntity Find(int id, params Expression<Func<TEntity, object>>[] includes);

        void ExecuteSqlCommand(string sql, List<SqlParameter> parameters);

        DbRawSqlQuery<TSpEntity> ExecProcedure<TSpEntity>(string procedureName, List<SqlParameter> parameters);

        DbRawSqlQuery<TSpEntity> SqlQuery<TSpEntity>(string sql, List<SqlParameter> parameters);
    }
}
