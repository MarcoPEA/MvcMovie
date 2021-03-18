using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
public class MyDemo2Controller : Controller
{
    [Route("/articles/{page}")]
    public IActionResult ListArticles(int page)
    {
        return ControllerContext.MyDisplayRouteInfo(page);
    }
}