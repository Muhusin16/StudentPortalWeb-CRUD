namespace StudentPortalWeb_CRUD.Models.Entities
{
    public class Manager
    {
        public int Id { get; set; }  // Unique identifier for the manager
        public string Name { get; set; }  // Name of the manager
        public string Email { get; set; }  // Email of the manager

        public ICollection<ManagerReview> ManagerReviews { get; set; }  // List of reviews given by this manager
    }

}
