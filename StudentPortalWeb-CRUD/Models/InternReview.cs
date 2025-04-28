namespace StudentPortalWeb_CRUD.Models
{
    public class InternFeedback
    {
        public int Id { get; set; }  // Unique identifier for the feedback

        public int InternId { get; set; }  // Foreign key to the Intern model
        public Intern Intern { get; set; }  // Navigation property to Intern

        public int MentorId { get; set; }  // Foreign key to the Mentor model
        public Mentor Mentor { get; set; }  // Navigation property to Mentor

        public double MentorRating { get; set; }  // Rating for the mentor (1-5)

        public string MentorFeedback { get; set; }  // Feedback about the mentor's performance

        public string ProgramSuggestions { get; set; }  // Suggestions for improving the internship program

        public DateTime FeedbackDate { get; set; }  // Date of feedback submission
    }


}
