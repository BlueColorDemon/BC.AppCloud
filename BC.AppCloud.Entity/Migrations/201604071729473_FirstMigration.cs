namespace BC.AppCloud.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApiCloud_ApiListItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        apiCode = c.String(),
                        apiName = c.String(),
                        apiDesc = c.String(),
                        apiInfo = c.String(),
                        apiUrl = c.String(),
                        apiRequestMethod = c.String(),
                        apiRequestSample = c.String(),
                        apiRequestRemarks = c.String(),
                        apiResponseSample = c.String(),
                        apiResponseRemarks = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        ApiCloud_ProjectListItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApiCloud_ProjectListItem", t => t.ApiCloud_ProjectListItem_Id)
                .Index(t => t.ApiCloud_ProjectListItem_Id);
            
            CreateTable(
                "dbo.ApiCloud_ApiRequestInputItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        inputNo = c.String(),
                        inputName = c.String(),
                        inputDesc = c.String(),
                        inputType = c.String(),
                        inputRequired = c.String(),
                        inputPosition = c.String(),
                        inputRange = c.String(),
                        inputDefault = c.String(),
                        inputExplain = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        ApiCloud_ApiListItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApiCloud_ApiListItem", t => t.ApiCloud_ApiListItem_Id)
                .Index(t => t.ApiCloud_ApiListItem_Id);
            
            CreateTable(
                "dbo.ApiCloud_ApiResponseOutputItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        outputNo = c.String(),
                        outputName = c.String(),
                        outputDesc = c.String(),
                        outputType = c.String(),
                        outputExplain = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        ApiCloud_ApiListItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApiCloud_ApiListItem", t => t.ApiCloud_ApiListItem_Id)
                .Index(t => t.ApiCloud_ApiListItem_Id);
            
            CreateTable(
                "dbo.ApiCloud_ProjectListItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        projectCode = c.String(),
                        projectName = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppCloud_AppGroupItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        desc = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        config_Id = c.Int(),
                        AppCloud_OrgGroupItem_Id = c.Int(),
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
                        Id = c.Int(nullable: false, identity: true),
                        CreateTime = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(),
                        State = c.Int(nullable: false),
                        baseframe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppCloud_Baseframe", t => t.baseframe_Id)
                .Index(t => t.baseframe_Id);
            
            CreateTable(
                "dbo.AppCloud_Baseframe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        Id = c.Int(nullable: false, identity: true),
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
            DropForeignKey("dbo.ApiCloud_ApiListItem", "ApiCloud_ProjectListItem_Id", "dbo.ApiCloud_ProjectListItem");
            DropForeignKey("dbo.ApiCloud_ApiResponseOutputItem", "ApiCloud_ApiListItem_Id", "dbo.ApiCloud_ApiListItem");
            DropForeignKey("dbo.ApiCloud_ApiRequestInputItem", "ApiCloud_ApiListItem_Id", "dbo.ApiCloud_ApiListItem");
            DropIndex("dbo.AppCloud_Config", new[] { "baseframe_Id" });
            DropIndex("dbo.AppCloud_AppGroupItem", new[] { "AppCloud_OrgGroupItem_Id" });
            DropIndex("dbo.AppCloud_AppGroupItem", new[] { "config_Id" });
            DropIndex("dbo.ApiCloud_ApiResponseOutputItem", new[] { "ApiCloud_ApiListItem_Id" });
            DropIndex("dbo.ApiCloud_ApiRequestInputItem", new[] { "ApiCloud_ApiListItem_Id" });
            DropIndex("dbo.ApiCloud_ApiListItem", new[] { "ApiCloud_ProjectListItem_Id" });
            DropTable("dbo.AppCloud_OrgGroupItem");
            DropTable("dbo.AppCloud_Baseframe");
            DropTable("dbo.AppCloud_Config");
            DropTable("dbo.AppCloud_AppGroupItem");
            DropTable("dbo.ApiCloud_ProjectListItem");
            DropTable("dbo.ApiCloud_ApiResponseOutputItem");
            DropTable("dbo.ApiCloud_ApiRequestInputItem");
            DropTable("dbo.ApiCloud_ApiListItem");
        }
    }
}
