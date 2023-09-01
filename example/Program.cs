global using static HtmlTagHelpers.TagHelpers;
using HtmlTagHelpers;


var myElements = new[] { "a", "b", "c" };

var document = html(
  head(
    script(
      """
      console.log('hello world')
      """
    )
  ),
  body(
    h1("Title Page"),
    p("this is some content"),
    // conditional expressions
    If(true, span("true"), span("false")),
    p(
      ("style", "border: 1px solid black;"),
      ("onClick", "console.log('clicked')"),
      "this paragraph has a border"
    ),
    p(("hidden", NO_VALUE), "hidden content"),
    MButton(Data(("onClick", "Console.log('override')")), "test"),
    ul(myElements.Map(i => li(i)))
  )
);

// example functional component
HtmlTag MButton(params HtmlContent[] content) =>
  button(
    Data(("onClick", "console.log('default')")),
    content
  );

Console.WriteLine(document.Render(0));
