namespace BloodBanking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Location = c.String(),
                        RegionId = c.String(),
                        Region_ID = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.Region_ID)
                .Index(t => t.Region_ID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DateofDonation = c.DateTime(nullable: false),
                        DonorId = c.String(),
                        Donor_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Donors", t => t.Donor_ID)
                .Index(t => t.Donor_ID);
            
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        BloodType = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donations", "Donor_ID", "dbo.Donors");
            DropForeignKey("dbo.Banks", "Region_ID", "dbo.Regions");
            DropIndex("dbo.Donations", new[] { "Donor_ID" });
            DropIndex("dbo.Banks", new[] { "Region_ID" });
            DropTable("dbo.Donors");
            DropTable("dbo.Donations");
            DropTable("dbo.Regions");
            DropTable("dbo.Banks");
        }
    }
}
