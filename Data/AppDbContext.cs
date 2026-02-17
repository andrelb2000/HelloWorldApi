using Microsoft.EntityFrameworkCore;
using HelloWorldApi.Models;

namespace HelloWorldApi.Data;

public class AppDbContext : DbContext {
 public AppDbContext(DbContextOptions<AppDbContext> options) 
 : base(options) { }
 
 public DbSet<ServiceRequest> ServiceRequests => Set<ServiceRequest>();
}
