namespace JobTrackerApp.Models
{
    public class JobApplication
    {
        public int JobId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Status { get; set; } = "Applied";
    }
}
