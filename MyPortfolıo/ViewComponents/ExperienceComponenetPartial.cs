using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;

namespace MyPortfolıo.ViewComponents
{
    public class ExperienceComponenetPartial: ViewComponent
    {
        private readonly AppDbContext _context;

        public ExperienceComponenetPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var model=_context.Experiences.FirstOrDefault();
            return View(model); 
            
        }
    }
}
