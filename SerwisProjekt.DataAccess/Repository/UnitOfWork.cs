using SerwisProjekt.DataAccess.Data;
using SerwisProjekt.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Repair = new RepairRepository(_db);
            SP_Call = new SP_Call(_db);

        }
        public IRepairRepository Repair { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
