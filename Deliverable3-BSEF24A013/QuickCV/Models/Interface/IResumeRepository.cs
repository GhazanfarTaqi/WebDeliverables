namespace QuickCV.Models.Interface
{
    public interface IResumeRepository
    {
        Task<IEnumerable<Resume>> GetForUserAsync(string userId);
        Task<Resume?> GetAsync(int id, string userId);
        Task<int> CreateAsync(Resume resume);
    }
}
