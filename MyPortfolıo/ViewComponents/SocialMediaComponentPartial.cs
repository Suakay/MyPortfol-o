using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;

namespace MyPortfolıo.ViewComponents
{
    public class SocialMediaComponentPartial: ViewComponent
    {
        private readonly AppDbContext _context;

        public SocialMediaComponentPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var socialMediaList = _context.SocialMedias.ToList();
            return View(socialMediaList.FirstOrDefault());

        }
    }
}
