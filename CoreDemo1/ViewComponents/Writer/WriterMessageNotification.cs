using Microsoft.AspNetCore.Mvc;

namespace CoreDemo1.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
         
            return View();
        }
    }
}
