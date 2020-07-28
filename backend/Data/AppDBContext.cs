using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace backend
{

    //This is basically the database  
    public class AppDBContext : IdentityDbContext<User>
    {
        //So this is the Users table,  
        public DbSet<User> Customer { get; set; } 
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
 

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;Database=EntitfyDB;persistsecurityinfo=True;Uid=root;Pwd=root;");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductOrder>().HasKey(po => new { po.ProductID, po.OrderNumber });
            modelBuilder.Entity<ProductOrder>().HasOne(po => po.Product).WithMany(p => p.ProductOrders).HasForeignKey(po => po.ProductID);
            modelBuilder.Entity<ProductOrder>().HasOne(po => po.Order).WithMany(o => o.ProductOrders).HasForeignKey(po => po.OrderNumber);
            modelBuilder.Entity<User>().HasMany(e => e.Orders).WithOne(e => e.Customer).HasForeignKey(e => e.CustomerUsername);

        }
         
    }

    public class Product
    {
        [Key]
        public string ProductID { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
    public class Order
    {

        [Key]
        public int OrderNumber { get; set; }
        public int OrderTotal { get; set; }
        //[ForeignKey("Customer")]
        public string CustomerUsername { get; set; }
        public User Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }

    }
    public class ProductOrder
    {
        public string ProductID { get; set; }
        public Product Product { get; set; }
        public int OrderNumber { get; set; }
        public Order Order { get; set; }
    }
    public class User : IdentityUser
    {
        
        public string First_name { get; set; }
        public string Last_name { get; set; } 
        public string Status { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
    

}