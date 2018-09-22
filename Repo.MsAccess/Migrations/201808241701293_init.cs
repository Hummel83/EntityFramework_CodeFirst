namespace MsAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Farben",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Farbe = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hunde",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Alter = c.Int(nullable: false),
                        BeinAnzahl = c.Byte(nullable: false),
                        Farbe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farben", t => t.Farbe_Id)
                .Index(t => t.Farbe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hunde", "Farbe_Id", "dbo.Farben");
            DropIndex("dbo.Hunde", new[] { "Farbe_Id" });
            DropTable("dbo.Hunde");
            DropTable("dbo.Farben");
        }
    }
}
