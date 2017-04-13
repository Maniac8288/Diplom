namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Grups22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentReceiveds", "Contract", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentReceiveds", "Contract");
        }
    }
}
