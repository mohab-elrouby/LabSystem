namespace Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Job = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestPatients",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        TestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PatientId, t.TestId })
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestPatients", "TestId", "dbo.Tests");
            DropForeignKey("dbo.TestPatients", "PatientId", "dbo.Patients");
            DropIndex("dbo.TestPatients", new[] { "TestId" });
            DropIndex("dbo.TestPatients", new[] { "PatientId" });
            DropTable("dbo.Tests");
            DropTable("dbo.TestPatients");
            DropTable("dbo.Patients");
        }
    }
}
