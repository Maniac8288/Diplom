namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estimates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Estimates", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Estimates");
        }
    }
}
