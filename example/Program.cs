global using static HtmlTagHelpers.Prelude;
using HtmlTagHelpers;

var myElements = new[] { "a", "b", "c" };

var document = html()(
  head()(
    script()(
      Raw(
        """
      console.log('hello world')
      """
      )
    )
  ),
  body()(
    h1()("Title Page"),
    p()("this is some content"),
    // conditional expressions
    If(true, span()("true"), span()("false")),
    p(
      ("style", "border: 1px solid black;"),
      ("onClick", "console.log('clicked')")
    )("this paragraph has a border"),
    p(Attr("hidden"))("hidden content"),
    MButton(Attrs(("onClick", "console.log('override')")), "test"),
    ul()(myElements.Select(i => li()(i)).ToArray())
  )
);

// example functional component
Eighty.Html MButton(IEnumerable<Eighty.Attr> attributes, string name) =>
  button(attributes.ToArray())(name);

Console.WriteLine(document.ToString());
