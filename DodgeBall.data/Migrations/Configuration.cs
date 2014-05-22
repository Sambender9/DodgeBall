namespace DodgeBall.data.Migrations
{
    using DodgeBall.DataModels;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DodgeBall.data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DodgeBall.data.ApplicationDbContext context)
        {
        context.Teams.AddOrUpdate(x => x.Name, 
            new Team() { Name= "Vipers", Logo="http://SomeLogoURL"},
            new Team() { Name= "Average Joes", Logo="http://SomeLogoURL"}
        );
            context.SaveChanges();
            context.Players.AddOrUpdate(p => new { p.Name, p.TeamId },
            new Player() {Name="Vince", TeamId=2, Picture="Tall and Gangly"},
            new Player() {Name="Zoolander", TeamId =1, Picture="Blue Steele"},
            new Player() {Name="Vince2", TeamId=2, Picture="Tall and Gangly"},
            new Player() {Name="Zoolander2", TeamId =1, Picture="Blue Steele"}
            );
            context.SaveChanges();
            
    
        }
    }
}
