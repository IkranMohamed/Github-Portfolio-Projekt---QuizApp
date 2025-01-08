using FluentValidation;

namespace Github_Portfolio_Projekt___QuizApp
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(player => player.Name).NotEmpty().WithMessage("Namnet får inte vara tomt.");
            RuleFor(player => player.Score).GreaterThanOrEqualTo(0).WithMessage("Poängen kan inte vara negativ.");
        }
    }
}
