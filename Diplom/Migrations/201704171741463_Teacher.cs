namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Teacher", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Teacher");
        }
    }
}
