namespace SportSystem.Data
{
    using System.Text.RegularExpressions;

    using SportSystem.Data.Repositories;
    using SportSystem.Models;

    public interface ISportSystemData
    {
        IRepository<User> Users { get; }

        IRepository<Team> Teams { get; }

        IRepository<SportSystem.Models.Match> Matches { get; }
        
        IRepository<Player> Players { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Vote> Votes { get; }

        IRepository<Bet> Bets { get; }

        int SaveChanges();
    }
}
