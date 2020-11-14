using FIAP.Models.Data.EntityMap;
using FIAP.Models.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models.Data
{
    public class DataContext : DbContext
    {
        private readonly PasswordService _service;

        public DataContext(DbContextOptions<DataContext> options, PasswordService service) : base(options)
        {
            _service = service;
        }

        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<LoginModel> Login { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string salt = _service.SaltCreate();

            builder.ApplyConfiguration(new UserMap());

            builder.Entity<LoginModel>().HasData(new LoginModel()
            {
                ID = 1,
                USERNAME = "admin",
                PASSWORD = _service.CryptPassword("admin", salt),
                ADMIN = true,
                SALT = salt
            });
        }
    }
}
