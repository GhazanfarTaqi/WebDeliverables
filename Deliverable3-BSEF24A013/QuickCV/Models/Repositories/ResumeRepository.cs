using QuickCV.Data;
using QuickCV.Models.Interface;
using Dapper;

namespace QuickCV.Models.Repositories
{
    public class ResumeRepository:IResumeRepository
    {

        private readonly IDbConnectionFactory _db;
        public ResumeRepository(IDbConnectionFactory db) => _db = db;

        public async Task<IEnumerable<Resume>> GetForUserAsync(string userId)
        {
            using var con = _db.Create();
            return await con.QueryAsync<Resume>(
                "SELECT * FROM Resumes WHERE UserId = @userId ORDER BY UpdatedAt DESC",
                new { userId });
        }

        Task<int> IResumeRepository.CreateAsync(Resume resume)
        {
            throw new NotImplementedException();
        }

        Task<Resume?> IResumeRepository.GetAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
