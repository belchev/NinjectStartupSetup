﻿using System;
using System.Data;
using System.Data.Entity;

namespace NinjectStartupSetup.Utils.Data
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext DbContext { get; }

        DbContextTransaction BeginTransaction();

        DbContextTransaction BeginTransaction(IsolationLevel isolationLevel);

        void Save();
    }
}
