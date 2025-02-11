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
            int correctAnswers = 0;

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
                    Console.WriteLine("Correct answer!");
                    correctAnswers++; // Öka antal rätt svar
                }
                else
                {
                    Console.WriteLine("Incorrect answer!"); // Feedback för fel svar
                }
            }

            // Uppdatera spelarens poäng baserat på antal rätt svar
            player.Score = correctAnswers;
            _ranking.AddPlayer(player);

            //Sammanfattning efter quizet
            Console.WriteLine($"You got {correctAnswers} out of {_questions.Count} questions right!");
        }
    }

}

