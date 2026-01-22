namespace OnlainSystemToPracticeForExamsMVC.Models
{
    public class AttemptAnswer
    {
        public int Id { get; set; }

        public int QuizAttemptId { get; set; }
        public QuizAttempt QuizAttempt { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int? SelectedOptionId { get; set; }
        public Option SelectedOption { get; set; }

        public bool IsCorrect { get; set; }
    }
}
