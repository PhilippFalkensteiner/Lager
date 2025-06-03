using Lager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Services
{
    public class DbManagerSQLite : DbContext {
        public DbSet<Product> Products { get; set; }

        public DbManagerSQLite() {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
           
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "app_db_local.db3");

            // C:\\Users\\maxim\\AppData\\Local\\User Name\\com.companyname.lager\\Data\\app_db_local.db3
            // C:\Users\maxim\AppData\Local\User Name\com.companyname.lager\Data

            optionsBuilder.UseSqlite($"Filename={dbPath}");

        }


    }
}
