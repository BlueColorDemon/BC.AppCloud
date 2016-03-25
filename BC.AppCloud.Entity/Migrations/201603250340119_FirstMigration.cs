namespace BC.AppCloud.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppCloud_AppGroupItem",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        name = c.String(),
                        desc = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        config_Id = c.Guid(),
                        AppCloud_OrgGroupItem_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppCloud_Config", t => t.config_Id)
                .ForeignKey("dbo.AppCloud_OrgGroupItem", t => t.AppCloud_OrgGroupItem_Id)
                .Index(t => t.config_Id)
                .Index(t => t.AppCloud_OrgGroupItem_Id);
            
            CreateTable(
                "dbo.AppCloud_Config",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        baseframe_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppCloud_Baseframe", t => t.baseframe_Id)
                .Index(t => t.baseframe_Id);
            
            CreateTable(
                "dbo.AppCloud_Baseframe",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppCloud_OrgGroupItem",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        name = c.String(),
                        desc = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppCloud_AppGroupItem", "AppCloud_OrgGroupItem_Id", "dbo.AppCloud_OrgGroupItem");
            DropForeignKey("dbo.AppCloud_AppGroupItem", "config_Id", "dbo.AppCloud_Config");
            DropForeignKey("dbo.AppCloud_Config", "baseframe_Id", "dbo.AppCloud_Baseframe");
            DropIndex("dbo.AppCloud_Config", new[] { "baseframe_Id" });
            DropIndex("dbo.AppCloud_AppGroupItem", new[] { "AppCloud_OrgGroupItem_Id" });
            DropIndex("dbo.AppCloud_AppGroupItem", new[] { "config_Id" });
            DropTable("dbo.AppCloud_OrgGroupItem");
            DropTable("dbo.AppCloud_Baseframe");
            DropTable("dbo.AppCloud_Config");
            DropTable("dbo.AppCloud_AppGroupItem");
        }
    }
}
