using HtmlTagHelpers;

namespace example_asp;

public class HomeController : AppController
{
  public IActionResult Index()
  {
    return V.Layout(
        h1()("Hello World"),
        div(id("content"))(
          a(
            href("https://github.com/saahilClaypool/htmlTagHelpers/"),
            ("target", "_blank")
          )("click here to learn more"),
          div()(CounterHtml(0))
        )
      )
      .ToActionResult();
  }

  public Html CounterHtml(int value) =>
    div(
      ("hx-get", "/home/counter"),
      ("hx-trigger", "click"),
      ("hx-swap", "outerHTML"),
      ("hx-include", "[name='value']")
    )(
      input(type("hidden"), name(nameof(value)), Prelude.value(value))(),
      div()($"value is {value}")
    );

  public IActionResult Counter(int value) =>
    CounterHtml(value + 1).ToActionResult();
}
