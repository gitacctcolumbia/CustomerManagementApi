using Microsoft.EntityFrameworkCore;
using CustomerManagementApi.Models;
namespace CustomerManagementApi.Data;
public class CustomerManagementContext : DbContext
{  
    public CustomerManagementContext(
           DbContextOptions<CustomerManagementContext> options) 
           : base (options)
    {
    }  
   public DbSet<Customer> Customers {get; set;}

}