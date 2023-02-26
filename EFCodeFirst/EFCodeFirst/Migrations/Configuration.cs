namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.EF.UMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirst.EF.UMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Departments.AddOrUpdate(
                    new EF.Models.Department()
                    {
                        Id = i,
                        Name = Guid.NewGuid().ToString().Substring(0, 7),

                    }
                );

            }
            Random random = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                context.Students.AddOrUpdate(
                    new EF.Models.Student()
                    {
                        Id = i,
                        Name = Guid.NewGuid().ToString().Substring(0, 10),
                        DepartmentId = random.Next(1, 11),
                        Cgpa = 2.5f + (float)random.NextDouble()
                    }
                ); ;
            }
        }
    }
}
