using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SerwisProjekt.Models;

namespace SerwisProjekt.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Naprawa> Naprawa { get; set; }
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Serwisant> Serwisant { get; set; }
        public DbSet<StatusNaprawy> StatusNaprawy { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }
        public DbSet<StatusZam> StatusZam { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }

    }
}
