using Microsoft.AspNetCore.Mvc;

namespace example_asp;

public abstract class AppController : Controller
{
  protected Views V =>
    Request.HttpContext.RequestServices.GetRequiredService<Views>();
}
