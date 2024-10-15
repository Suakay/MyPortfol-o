using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;

namespace MyPortfolıo.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public AboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model=_context.Abouts.FirstOrDefault();
            return View(model);
        }

        

    }
}
