namespace PMS_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTable_PkFkAddedV10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        CId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CId, cascadeDelete: true)
                .Index(t => t.CId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OId = c.Int(nullable: false),
                        PId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.PId, cascadeDelete: true)
                .Index(t => t.OId)
                .Index(t => t.PId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        OrderedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.OrderedBy)
                .Index(t => t.OrderedBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "PId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderedBy", "dbo.Users");
            DropForeignKey("dbo.Products", "CId", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "OrderedBy" });
            DropIndex("dbo.OrderDetails", new[] { "PId" });
            DropIndex("dbo.OrderDetails", new[] { "OId" });
            DropIndex("dbo.Products", new[] { "CId" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
