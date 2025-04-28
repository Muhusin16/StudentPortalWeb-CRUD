namespace StudentPortalWeb_CRUD.Models.Entities
{
    public class Intern
    {
        public int Id { get; set; }  // Unique identifier for intern
        public string Name { get; set; }  // Name of the intern
        public string Email { get; set; }  // Email of the intern
        public string Contact { get; set; }  // Contact details of the intern
        public string Skills { get; set; }  // Skills listed by the intern

        public ICollection<ManagerReview> ManagerReviews { get; set; }  // List of manager reviews
        public ICollection<MentorFeedback> MentorFeedbacks { get; set; }  // List of mentor feedbacks
        public ICollection<InternFeedback> InternFeedbacks { get; set; }  // List of intern feedbacks
    }

}
