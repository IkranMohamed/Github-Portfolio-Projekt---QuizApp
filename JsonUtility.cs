using System.Text.Json;

namespace Github_Portfolio_Projekt___QuizApp
{
    public static class JsonUtility
    {
        public static List<Question> ReadQuestionsFromFile(string filePath)
        {
            try
            {

                var jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Question>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid läsning av fil: {ex.Message}");
                return new List<Question>(); // Återvänd en tom lista vid fel

            }
        }

        public static void WriteRankingToFile(Ranking ranking, string filePath)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(ranking.Players);
                File.WriteAllText(filePath, jsonString);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid skrivning till fil: {ex.Message}");
            }
        }
    }
}