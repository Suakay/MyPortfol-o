using Microsoft.AspNetCore.Mvc;
using MyPortfolıo.DAL.Context;

namespace MyPortfolıo.ViewComponents
{
    public class ContactComponentPartial: ViewComponent
    {
        private readonly AppDbContext _context;

        public ContactComponentPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var model=_context.Contacts.FirstOrDefault();
            return View(model); 
        }

    }
}
