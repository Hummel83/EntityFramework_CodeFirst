namespace DB_Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Farben",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Farb = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hunde",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Alter = c.Int(nullable: false),
                        Farben_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farben", t => t.Farben_Id)
                .Index(t => t.Farben_Id);
            
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Hunde", "Farben_Id", "dbo.Farben");
            DropIndex("dbo.Hunde", new[] { "Farben_Id" });
            DropTable("dbo.Hunde");
            DropTable("dbo.Farben");
        }
    }
}
