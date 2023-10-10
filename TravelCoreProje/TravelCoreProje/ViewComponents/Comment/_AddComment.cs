using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
