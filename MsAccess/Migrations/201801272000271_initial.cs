using System.Data.Entity.Migrations;

namespace MsAccess
{
    public class Initial : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Farben",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Farb = c.String(unicode: false),
                })
                .PrimaryKey(t => t.Id);

            this.CreateTable(
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
            this.DropIndex("dbo.Hunde", new[] { "Farben_Id" });
            this.DropTable("dbo.Hunde");
            this.DropTable("dbo.Farben");
        }
    }
}
