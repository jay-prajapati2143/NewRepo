namespace MyMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        standard_StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Standards", t => t.standard_StandardId)
                .Index(t => t.standard_StandardId);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "standard_StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "standard_StandardId" });
            DropTable("dbo.Standards");
            DropTable("dbo.Students");
        }
    }
}
