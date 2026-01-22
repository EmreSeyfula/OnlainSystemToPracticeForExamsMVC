namespace OnlainSystemToPracticeForExamsMVC.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Topic> Topics { get; set; }
    }
}
