using Microsoft.CodeAnalysis.Options;

namespace OnlainSystemToPracticeForExamsMVC.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsActive { get; set; } = true;

        // Връзка с тема
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
