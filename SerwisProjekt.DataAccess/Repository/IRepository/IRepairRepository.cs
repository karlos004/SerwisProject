using SerwisProjekt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository.IRepository
{
    public interface IRepairRepository : IRepository<Naprawa>
    {
        void Update(Naprawa repair);
    }
}
