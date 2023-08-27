global using static HtmlTagHelpers.TagHelpers;
using HtmlTagHelpers;

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
    p(Data(("hidden", NO_VALUE)), "hidden content"),
    MButton(Data(("onClick", "Console.log('override')")), "test")
  )
);

// example functional component
HtmlTag MButton(HData data, params object[] content) =>
  button(
    Data(("onClick", "console.log('default')")).Merge(data),
    children: content
  );

Console.WriteLine(document.Render(0));
