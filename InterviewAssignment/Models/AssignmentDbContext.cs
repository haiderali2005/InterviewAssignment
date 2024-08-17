using Microsoft.EntityFrameworkCore;

namespace InterviewAssignment.Models
{
    public class AssignmentDbContext:DbContext
    {
        public AssignmentDbContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet<Order> table_order {  get; set; }
        public DbSet<OrderDetail> table_orderdetail {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
           .HasMany(o => o.orderdetail)
           .WithOne(od => od.Order)
           .HasForeignKey(od => od.Order_id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
