namespace QuickCV.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string ResumeId { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ExperienceBullet> Bullets { get; set; } = new();

    }
}
