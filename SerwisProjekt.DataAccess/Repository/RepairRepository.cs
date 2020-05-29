using SerwisProjekt.DataAccess.Data;
using SerwisProjekt.DataAccess.Repository.IRepository;
using SerwisProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerwisProjekt.DataAccess.Repository
{
    public class RepairRepository : Repository<Naprawa>, IRepairRepository
    {
        private readonly ApplicationDbContext _db;

        public RepairRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Zamowienie> GetAll()
        {
            var list = _db.Zamowienie.ToList<Zamowienie>();
            return list;
        }
        public Zamowienie GetId(int id)
        {
            return _db.Zamowienie.FirstOrDefault(s => s.ZamId == id);
        }
        public void DeleteOrder(int id)
        {
            Zamowienie zamowienie = new Zamowienie() { ZamId = id };
            _db.Zamowienie.Attach(zamowienie);
            _db.Zamowienie.Remove(zamowienie);
            _db.SaveChanges();
        }
        public Klient Register(string imienazwisko, string numertel, string email, byte[] pass)
        {
            var klient = new Klient();
            klient.ImieNazwisko = imienazwisko;
            klient.NumerTel = numertel;
            klient.Email = email;
            klient.Haslo = pass;
            _db.Add<Klient>(klient);
            _db.SaveChanges();
            return klient;
        }

        public void UpdateOrder(Zamowienie zamowienie)
        {
            int id = zamowienie.ZamId;
            using (var db = _db)
            {
                var result = db.Zamowienie.SingleOrDefault(b => b.ZamId == id);
                if (result != null)
                {
                    result = zamowienie;
                    db.SaveChanges();
                }
            }
        }

        public void Update(Naprawa repair)
        {
            var objFromDb = _db.Naprawa.FirstOrDefault(s => s.NaprawaId == repair.NaprawaId);
            if (objFromDb != null)
            {
                objFromDb.StatusId = repair.StatusId;
                _db.SaveChanges();
            }
        }
    }
}
