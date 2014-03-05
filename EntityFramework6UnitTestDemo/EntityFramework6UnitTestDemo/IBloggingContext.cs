using System;
namespace EntityFramework6UnitTestDemo
{
    public interface IBloggingContext
    {
        System.Data.Entity.DbSet<Blog> Blogs { get; set; }
        System.Data.Entity.DbSet<Post> Posts { get; set; }

        int SaveChanges();
    }
}
