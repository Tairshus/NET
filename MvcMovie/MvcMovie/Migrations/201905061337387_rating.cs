namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "rating");
        }
    }
}
