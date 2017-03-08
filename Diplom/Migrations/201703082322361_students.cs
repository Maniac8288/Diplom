namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class students : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        NameStudent = c.String(),
                        SecondName = c.String(),
                        Nationality = c.String(),
                        DateBirth = c.DateTime(nullable: false),
                        DateDocument = c.DateTime(nullable: false),
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
                        EndSchool = c.DateTime(nullable: false),
                        GPA = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
