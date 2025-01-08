using Spectre.Console;

namespace Github_Portfolio_Projekt___QuizApp
{
    public class Menu
    {
        private QuizService _quizService;
        private Ranking _ranking;


        // Konstruktor för att ta in quizservice och ranking
        public Menu()
        {
            _ranking = new Ranking();
            var questions = JsonUtility.ReadQuestionsFromFile("questions.json");
            _quizService = new QuizService(questions, _ranking);
        }

        public void DisplayMainMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Spectre.Console.AnsiConsole.Markup("[bold yellow]Quiz Game[/]");
                var menu = new Spectre.Console.SelectionPrompt<string>()
                    .AddChoices("Start Quiz", "View Ranking", "Exit");

                var choice = AnsiConsole.Prompt(menu);

                switch (choice)
                {
                    case "Start Quiz":
                        StartQuiz();
                        break;
                    case "View Ranking":
                        ViewRanking();
                        break;
                    case "Exit":
                        exit = true;
                        break;
                }
            }
        }
        private void StartQuiz()
        {
            var player = new Player { Name = "Ikrans Quiz", Score = 10 };
            _quizService.StartQuiz(player);

        }

        private void ViewRanking()
        {
            _ranking.DisplayRanking();

        }
    }
}   



