namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class group : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "NumberGroup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "NumberGroup");
        }
    }
}
