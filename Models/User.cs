using Microsoft.AspNetCore.Identity;

namespace OnlainSystemToPracticeForExamsMVC.Models

{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

      
        public ICollection<QuizAttempt> QuizAttempts { get; set; }
    }
}
