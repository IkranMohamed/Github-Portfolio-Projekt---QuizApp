namespace Github_Portfolio_Projekt___QuizApp
{
    public class QuizService
        {
            private List<Question> _questions;
            private Ranking _ranking;

            public QuizService(List<Question> questions, Ranking ranking)
            {
                _questions = questions;
                _ranking = ranking;
            }

            public void StartQuiz(Player player)
            {
                foreach (var question in _questions)
                {
                    Console.WriteLine(question.Text);
                    foreach (var option in question.Options)
                    {
                        Console.WriteLine(option);
                    }

                    var answer = Console.ReadLine();
                    if (answer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        player.Score += 10; // Each right answer
                    }
                }

                _ranking.AddPlayer(player);
            }
        }

    }

