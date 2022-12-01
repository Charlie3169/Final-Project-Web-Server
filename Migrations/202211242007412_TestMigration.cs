namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Major = c.String(),
                        Concentration = c.String(),
                        Year = c.Int(nullable: false),
                        FavoriteFood = c.String(),
                        FavoriteSong = c.String(),
                        Hometown = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }

        public override void Down()
        {
            DropTable("dbo.Students");
        }

    }
}
