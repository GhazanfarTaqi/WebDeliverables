namespace QuickCV.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public int TemplateId { get; set; }
        public string Title { get; set; } = "";
        public string FullName { get; set; } = "";
        public string? JobTitle { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Education> Educations { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
    }
}
