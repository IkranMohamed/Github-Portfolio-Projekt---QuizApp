using Spectre.Console;

namespace Github_Portfolio_Projekt___QuizApp
{
    public class Menu
    {
        private QuizService _quizService;
        private Ranking _ranking;


        // Konstruktor 
        public Menu()
        {

            var questions = JsonUtility.ReadQuestionsFromFile("questions.json");
            _ranking = new Ranking(questions.Count);
            _quizService = new QuizService(questions, _ranking);
        }

        public void DisplayMainMenu()
        {
            bool exit = false;

            while (!exit)
            {
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
            var playerName = AnsiConsole.Ask<string>("Please enter your name:");
            var player = new Player { Name = playerName, Score = 0 };

            //Starta Quizet
            _quizService.StartQuiz(player);

            //Visa rankningen efter quizet
            AnsiConsole.Markup("[bold green]Quiz finished! Here's the [/]");
            _ranking.DisplayRanking();
        }

        private void ViewRanking()
        {
            _ranking.DisplayRanking();

        }
    }
}



