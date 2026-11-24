namespace QuickCV.Models.Interface
{
    public interface ISkillRepository
    {
        public void AddSkill(Skill skill);
        public Task<List<Skill>> GetSkillsByResumeIdAsync(string resumeId);
    }
}
