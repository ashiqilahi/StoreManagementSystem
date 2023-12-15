using Microsoft.EntityFrameworkCore;

using MessageApi.Models;

namespace MessageApi.Data;
    public class StoreMS:DbContext
{
    public StoreMS(DbContextOptions<StoreMS>options):base(options)
    {
        
    }
    public DbSet<Message> Messages{get; set;}
}
