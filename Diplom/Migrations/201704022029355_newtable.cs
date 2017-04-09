namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentReceiveds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        NameStudent = c.String(),
                        SecondName = c.String(),
                        Nationality = c.String(),
                        DateBirth = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        DateDocument = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        Social = c.String(),
                        Language = c.String(),
                        Citizenship = c.String(),
                        ForeignLanguage = c.String(),
                        Phone = c.String(),
                        MilitaryID = c.String(),
                        House = c.String(),
                        Sex = c.String(),
                        Dormitories = c.String(),
                        Documents = c.String(),
                        School = c.String(),
                        EndSchool = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        GPA = c.Double(nullable: false),
                        NumberGroup = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentReceiveds");
        }
    }
}
