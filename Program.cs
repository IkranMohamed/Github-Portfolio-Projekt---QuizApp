using System.ComponentModel.Design;

namespace Github_Portfolio_Projekt___QuizApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Läs in frågor från en JSON-fil
            var questions = JsonUtility.ReadQuestionsFromFile("questions.json");

            // Skapa en ranking och en quizservice
            var ranking = new Ranking();
            var quizService = new QuizService(questions, ranking);

            // Skapa en spelare
            var player = new Player { Name = "Ikrans värld", Score = 0 };

           var menu = new Menu();
           menu.DisplayMainMenu();
        }
    }
}