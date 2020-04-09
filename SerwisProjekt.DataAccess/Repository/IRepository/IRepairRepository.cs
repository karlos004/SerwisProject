using SerwisProjekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository.IRepository
{
    public interface IRepairRepository : IRepository<Repair>
    {
        void Update(Repair repair);
    }
}
