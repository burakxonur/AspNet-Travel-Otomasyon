using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
