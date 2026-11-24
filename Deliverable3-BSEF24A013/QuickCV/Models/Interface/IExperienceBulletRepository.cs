namespace QuickCV.Models.Interface
{
    public interface IExperienceBulletRepository
    {
        public void AddExperienceBullet(ExperienceBullet experienceBullet);
        public Task<List<ExperienceBullet>> GetExperienceBulletByExperienceIdAsync(string experienceId);
    }
}
