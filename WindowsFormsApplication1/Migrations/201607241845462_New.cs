namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Part",
                c => new
                    {
                        QuickID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        PartNumber = c.String(),
                        Location = c.String(),
                        SerialNumber = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        Quantity = c.String(),
                    })
                .PrimaryKey(t => t.QuickID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        QuickID = c.Int(nullable: false),
                        TechID = c.Int(nullable: false),
                        TransactionType = c.Int(),
                        Quantity = c.Int(nullable: false),
                        Destination = c.String(),
                        Reason = c.String(),
                        TimeStamp = c.DateTime(),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Part", t => t.QuickID, cascadeDelete: true)
                .ForeignKey("dbo.Tech", t => t.TechID, cascadeDelete: true)
                .Index(t => t.QuickID)
                .Index(t => t.TechID);
            
            CreateTable(
                "dbo.Tech",
                c => new
                    {
                        TechID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.TechID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaction", "TechID", "dbo.Tech");
            DropForeignKey("dbo.Transaction", "QuickID", "dbo.Part");
            DropIndex("dbo.Transaction", new[] { "TechID" });
            DropIndex("dbo.Transaction", new[] { "QuickID" });
            DropTable("dbo.Tech");
            DropTable("dbo.Transaction");
            DropTable("dbo.Part");
        }
    }
}
