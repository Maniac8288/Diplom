namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Grups2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Groups");
            AddColumn("dbo.Groups", "key", c => c.String());
            AlterColumn("dbo.Groups", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Groups");
            AlterColumn("dbo.Groups", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Groups", "key");
            AddPrimaryKey("dbo.Groups", "Id");
        }
    }
}
