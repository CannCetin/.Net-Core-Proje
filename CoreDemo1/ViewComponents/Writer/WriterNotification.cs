using Microsoft.AspNetCore.Mvc;

namespace CoreDemo1.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
