namespace MultipleFormsInTheSameViewSample.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MultipleFormsInTheSameViewSample.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Models.DataContext context)
        {

        }
    }
}
