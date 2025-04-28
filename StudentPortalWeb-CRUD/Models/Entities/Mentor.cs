namespace StudentPortalWeb_CRUD.Models.Entities
{
    public class Mentor
    {
        public int Id { get; set; }  // Unique identifier for the mentor
        public string Name { get; set; }  // Name of the mentor
        public string Email { get; set; }  // Email of the mentor

        public ICollection<MentorFeedback> MentorFeedbacks { get; set; }  // List of feedbacks given by this mentor
    }

}
