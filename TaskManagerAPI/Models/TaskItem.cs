namespace TaskManagerAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // e.g. Pending, Completed
    }
}
