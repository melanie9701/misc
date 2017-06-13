namespace EntityFramework.Tutorial.ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blah : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Blah", c => c.String());
            AddColumn("dbo.Blogs", "Blub", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Blub");
            DropColumn("dbo.Blogs", "Blah");
        }
    }
}
