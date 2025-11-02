using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sklad2.Core.DTO;

namespace Sklad2.Core
{
    public class DataContext:DbContext
    {
        public DbSet<ApplicationDto> Application {  get; set; }
        

        public DbSet<ApplicationItemsDto> ApplicationItems { get; set; }


        public DbSet<ScrapTypeCategoryDto> ScrapTypesCategory { get; set; }


        public DbSet<ScrapTypeDto> ScrapTypes { get; set; }


        public DbSet<SupplierDto> Suppliers { get; set; }


        public DbSet<UserDto> User { get; set; }


        public DbSet<UserRoleDto> UserRoles { get; set; }


        public DbSet<WareHouseDto> WareHouses { get; set; }


        public DbSet<WareHouseSectionDto> WareHouseItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localHost; Port=5432; User Id=postgres;Password=Gaefamafa12;Database=NewAluminiumStorageSystem2;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
