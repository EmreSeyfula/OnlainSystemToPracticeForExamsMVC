namespace OnlainSystemToPracticeForExamsMVC.Models
{
    public class Topic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; } = true;

        
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
