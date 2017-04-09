namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhonePareant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "PhonePareant", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "PhonePareant");
        }
    }
}
