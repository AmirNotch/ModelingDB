using Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain_Models
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }
        
        /*public DbSet<CategoryProducts> CategoryProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // One to many and many to one table for Category Products 
            builder.Entity<CategoryProducts>(x => x.HasKey(cp => new {cp.CategoryId, cp.ProductId}));

            builder.Entity<CategoryProducts>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(cp => cp.CategoryId);
            
            builder.Entity<CategoryProducts>()
                .HasOne(c => c.Product)
                .WithMany(c => c.Categories)
                .HasForeignKey(cp => cp.ProductId);
            
            // One to many and many to one table for Order Products
            builder.Entity<OrderProducts>(x => x.HasKey(op => new {op.OrderId, op.ProductId}));

            builder.Entity<OrderProducts>()
                .HasOne(o => o.Order)
                .WithMany(o => o.Products)
                .HasForeignKey(cp => cp.OrderId);
            
            builder.Entity<OrderProducts>()
                .HasOne(o => o.Product)
                .WithMany(o => o.Orders)
                .HasForeignKey(cp => cp.ProductId);
            
            
            // one to many for all event
            builder.Entity<ProductEvent>()
                .HasOne(o => o.Product)
                .WithMany(o => o.Events)
                .HasForeignKey(cp => cp.ProductId);
            
            builder.Entity<OrderEvent>()
                .HasOne(o => o.Order)
                .WithMany(o => o.Events)
                .HasForeignKey(cp => cp.OrderId);
            
            // one to many for orders
            builder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany(o => o.Orders)
                .HasForeignKey(cp => cp.ClientId);
            
            builder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany(o => o.Orders)
                .HasForeignKey(cp => cp.AddressId);
            
            builder.Entity<Order>()
                .HasOne(o => o.PaymentMethod)
                .WithMany(o => o.Orders)
                .HasForeignKey(cp => cp.PaymentMethodId);
            
            /*// one to many to clients table
            builder.Entity<Client>()
                .HasOne(o => o.PaymentMethod)
                .WithMany(o => o.Clients)
                .HasForeignKey(cp => cp.PaymentMethodId);
            
            builder.Entity<Client>()
                .HasOne(o => o.Address)
                .WithMany(o => o.Clients)
                .HasForeignKey(cp => cp.AddressId);*/
        }
        
    }
}