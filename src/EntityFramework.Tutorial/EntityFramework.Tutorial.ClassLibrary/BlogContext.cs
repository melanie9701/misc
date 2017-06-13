using System.Data.Entity;

namespace EntityFramework.Tutorial.ClassLibrary
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public string Blah { get; set; }

        public string Blub { get; set; }
    }
}
