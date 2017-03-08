namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class students2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DateBirth", c => c.DateTime(nullable: false, precision: 0, storeType: "datetime2"));
            AlterColumn("dbo.Students", "DateDocument", c => c.DateTime(nullable: false, precision: 0, storeType: "datetime2"));
            AlterColumn("dbo.Students", "EndSchool", c => c.DateTime(nullable: false, precision: 0, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "EndSchool", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "DateDocument", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "DateBirth", c => c.DateTime(nullable: false));
        }
    }
}
