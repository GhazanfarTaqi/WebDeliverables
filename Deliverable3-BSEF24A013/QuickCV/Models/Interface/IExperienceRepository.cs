namespace QuickCV.Models.Interface
{
    public interface IExperienceRepository
    {
        public void AddExperience(Experience experience);
        public Task<List<Experience>> GetExperienceByResumeIdAsync(string resumeId);
    }
}
