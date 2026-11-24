namespace QuickCV.Models.Interface
{
    public interface IEducationRepository
    {
        public Task<List<Education>> GetEducationByResumeIdAsync(string resumeId);
        public void AddEducation(Education education);

    }
}
