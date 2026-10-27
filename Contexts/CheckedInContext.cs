using Microsoft.EntityFrameworkCore;
using CheckedIn.Api.Models;
namespace CheckedIn.Api;

public class CheckedInContext : DbContext
{
    // Constructor to instantiate a Context - gives parameters which will be filled in 
    // (dependency injection)
    // This is a public constructor for CheckedInContext. 
    // It must be given an options object meant for CheckedInContext
    // which it calls options. Before doing anything else, it hands those options to its parent DbContext, and then it does nothing more.

    public CheckedInContext(DbContextOptions<CheckedInContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<Coordinator> Coordinators { get; set; }

}
