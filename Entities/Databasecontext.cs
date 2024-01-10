using Microsoft.EntityFrameworkCore;
using osp.Entities;
using osp.Models;

public class Databasecontext : DbContext
{
    public Databasecontext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public object Questions { get; internal set; }

    public DbSet<QuestionModel> Question { get; set; }

    internal int SaveChanges()
    {
        throw new NotImplementedException();
    }
}
