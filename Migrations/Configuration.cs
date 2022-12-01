namespace Final_Project.Migrations
{
    using Final_Project.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Final_Project.Models.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Final_Project.Models.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var students = new List<Student>
            {
                new Student { StudentId = 1,
                        Name = "FRANCESCA SUBA",
                        Major = "Information Technology",
                        Concentration = "Software Development",
                        Year = 4,
                        FavoriteFood = "Chipotle",
                        FavoriteSong = "The Spins by Mac Miller",
                        Hometown = "Pampanga and Cincinnati" },
                new Student { StudentId = 2,
                        Name = "VEDANT AMIN",
                        Major = "Information Technology",
                        Concentration = "Software Development",
                        Year = 4,
                        FavoriteFood = "Pizza",
                        FavoriteSong = "Hills by The Weeknd",
                        Hometown = "Cleveland" },
                new Student { StudentId = 3,
                        Name = "Test",
                        Major = "Test",
                        Concentration = "Test",
                        Year = 4,
                        FavoriteFood = "Test",
                        FavoriteSong = "Test",
                        Hometown = "Test" }
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
