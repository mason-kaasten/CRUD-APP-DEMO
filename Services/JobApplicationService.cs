namespace JobTrackerApp.Services
{
    using JobTrackerApp.Models;
    public class JobApplicationService
    {
        private readonly List<JobApplication> _jobs = new();
        private int _nextId = 1;
        public List<JobApplication> GetAll() => _jobs;
        public void Add(JobApplication job)
        {
            job.JobId = _nextId++;
            _jobs.Add(job);
        }
        public void Update(JobApplication job)
        {
            var existing = _jobs.FirstOrDefault(j => j.JobId == job.JobId);
            if (existing != null)
            {
                existing.CompanyName = job.CompanyName;
                existing.JobTitle = job.JobTitle;
                existing.Status = job.Status;
            }
        }
        public void Delete(int jobId)
        {
            var job = _jobs.FirstOrDefault(j => j.JobId == jobId);
            if (job != null) _jobs.Remove(job);
        }
    }
}
