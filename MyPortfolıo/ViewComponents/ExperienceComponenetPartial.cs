using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;
using MyPortfolıo.DAL.Entites;

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
            var models=_context.Experiences.ToList();
            return View(models); 
            
        }
       

    }
}
