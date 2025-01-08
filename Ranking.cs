namespace Github_Portfolio_Projekt___QuizApp
{
    public class Ranking
    {
        public List<Player> Players { get; set; }

        public Ranking() 
        {

            Players = new List<Player>();

        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void DisplayRanking()
        {
            var topPlayers = Players.OrderByDescending(p => p.Score).ToList();
            foreach (var player in Players)
            {
                Console.WriteLine($"Rank {player.Rank}: {player.Name} - {player.Score} points");
            }

        }

    }
}
