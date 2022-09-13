namespace TaskModels
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
        public string Description { get; set; }
    }
}