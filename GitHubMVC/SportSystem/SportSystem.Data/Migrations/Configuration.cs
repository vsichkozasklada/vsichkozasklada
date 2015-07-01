namespace SportSystem.Data.Migrations
{
    using SportSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportSystem.Data.SportSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SportSystem.Data.SportSystemDbContext context)
        {



            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1878, 06, 1),
                TeamName = "Manchester United F.C.",
                TeamNickName = "The Red Devils",
                Website = "http://www.manutd.com"
            });
            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1902, 03, 6),
                TeamName = "Real Madrid",
                TeamNickName = "The Whites",
                Website = "http://www.realmadrid.com"
            });
            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1899, 11, 12),
                TeamName = "FC Barcelona",
                TeamNickName = "Barc",
                Website = "http://www.manutd.com"
            });
            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1900, 02, 13),
                TeamName = "Bayern Munich",
                TeamNickName = "The Bavarians",
                Website = "http://www.fcbayern.de"
            });
            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1899, 11, 12),
                TeamName = "Manchester City",
                TeamNickName = "Citizens",
                Website = "http://www.manutd.com"
            });

            context.Teams.Add(new Team
            {
                DateFounded = new DateTime(1899, 11, 12),
                TeamName = "Chelsea.",
                TeamNickName = "Pensioneers",
                Website = "http://www.manutd.com"
            });

            //context.Players.Add(new Player
            //{
            //    Height = 165,
            //    PlayerName = "Pesho",
            //    Team = context.Teams.FirstOrDefault(),   
            //    TeamId = context.Teams.FirstOrDefault().Id
            //});            
        }
    }
}
