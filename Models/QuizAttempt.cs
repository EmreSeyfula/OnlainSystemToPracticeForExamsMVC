
namespace OnlainSystemToPracticeForExamsMVC.Models
{
    public class QuizAttempt
    {
        public int Id { get; set; }

        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }

        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }

        public double Percentage { get; set; }
        public int Grade { get; set; }

        // Връзка с ученик
        public string UserId { get; set; }
        public User User { get; set; }

        // Връзка с тема
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<AttemptAnswer> Answers { get; set; }
    }
}
