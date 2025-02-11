namespace Github_Portfolio_Projekt___QuizApp
{
    public class Ranking
    {
        public List<Player> Players { get; set; }
        public int TotalQuestions { get; set; }

        public Ranking(int totalQuestions)
        {

            Players = new List<Player>();
            TotalQuestions = totalQuestions;

        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void DisplayRanking()
        {
            var topPlayers = Players.OrderByDescending(p => p.Score).ToList();
            Console.WriteLine("Ranking:");
            for (int i = 0; i < topPlayers.Count; i++)
            {

                Console.WriteLine($"Rank {i + 1}: {topPlayers[i].Name} - {topPlayers[i].Score}/{TotalQuestions} correct answers");

            }
        }
    }
}
