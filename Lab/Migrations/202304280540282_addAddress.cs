namespace Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddress : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TestPatients");
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Governorate = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Patients", "adress_Id", c => c.Int());
            AddColumn("dbo.TestPatients", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TestPatients", "Doctor", c => c.String());
            AddPrimaryKey("dbo.TestPatients", "Id");
            CreateIndex("dbo.Patients", "adress_Id");
            AddForeignKey("dbo.Patients", "adress_Id", "dbo.Adresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "adress_Id", "dbo.Adresses");
            DropIndex("dbo.Patients", new[] { "adress_Id" });
            DropPrimaryKey("dbo.TestPatients");
            DropColumn("dbo.TestPatients", "Doctor");
            DropColumn("dbo.TestPatients", "Id");
            DropColumn("dbo.Patients", "adress_Id");
            DropTable("dbo.Adresses");
            AddPrimaryKey("dbo.TestPatients", new[] { "PatientId", "TestId" });
        }
    }
}
