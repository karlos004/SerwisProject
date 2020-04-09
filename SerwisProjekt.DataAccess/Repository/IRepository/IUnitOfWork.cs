using System;
using System.Collections.Generic;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepairRepository Repair { get; }
        ISP_Call SP_Call { get; }
    }
}
