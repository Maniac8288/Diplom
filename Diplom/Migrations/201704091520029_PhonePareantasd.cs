namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhonePareantasd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentReceiveds", "Estimates", c => c.String());
            AddColumn("dbo.StudentReceiveds", "PhonePareant", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentReceiveds", "PhonePareant");
            DropColumn("dbo.StudentReceiveds", "Estimates");
        }
    }
}
