using SerwisProjekt.DataAccess.Data;
using SerwisProjekt.DataAccess.Repository.IRepository;
using SerwisProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository
{
    public class RepairRepository : Repository<Repair>, IRepairRepository
    {
        private readonly ApplicationDbContext _db;

        public RepairRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Repair repair)
        {
            var objFromDb = _db.Repairs.FirstOrDefault(s => s.Id == repair.Id);
            if (objFromDb != null)
            {
                objFromDb.StatusId = repair.StatusId;
                _db.SaveChanges();
            }
        }
    }
}
