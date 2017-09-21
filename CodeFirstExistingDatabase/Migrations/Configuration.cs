namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstExistingDatabase.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // used to initialize development DB w/dummy data
        // DO NOT USE to store reference data that might be deployed to production 
        // if you have reference data the way to do it is to create an empty migration
        //  and use the sql method to populate the DB in the migration.cs file
        protected override void Seed(CodeFirstExistingDatabase.PlutoContext context)
        {
            // how to add data to your development database
            //context.Authors.AddOrUpdate(a => a.Name, 
            //    new Author
            //    {
            //        Name = "Author 1",
            //        Courses = new List<Course>()
            //        {
            //            new Course() {Name = "Course for Author 1", Description = "Course Description" }
            //        }
            //    });

        }
    }
}
