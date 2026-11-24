using Microsoft.AspNetCore.Mvc;
using QuickCV.Models;
using QuickCV.Models.Interface;
using System.Security.Claims;


namespace QuickCV.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IResumeRepository _resumes;

        private string UserId => User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        public async Task<IActionResult> Index()
        {
            //var resumes = await _resumes.GetForUserAsync(UserId);
            List<Resume> resumes = new List<Resume>
            {
                new Resume { Id = 1, FullName = "Resume 1", UserId = UserId },
                new Resume { Id = 2, FullName = "Resume 2", UserId = UserId },
                new Resume { Id = 3, FullName = "Resume 3", UserId = UserId }
            };
            return PartialView("_ResumeCard", resumes);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var resume = await _resumes.GetAsync(id, UserId);
            return resume is null ? NotFound() : View(resume);
        }

    }
}
