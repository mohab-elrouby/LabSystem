namespace Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTestPatient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestPatients", "PriceAfterDiscount", c => c.Single(nullable: false));
            AddColumn("dbo.TestPatients", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestPatients", "Date");
            DropColumn("dbo.TestPatients", "PriceAfterDiscount");
        }
    }
}
