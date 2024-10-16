using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;

namespace MyPortfolıo.ViewComponents
{
    public class SkillComponenetPartial: ViewComponent
    {
        private readonly AppDbContext _context;

        public SkillComponenetPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var models=_context.Skills.ToList(); 
            return View(models);
        }
    }
}
