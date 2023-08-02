global using static HFunc.TagHelpers;

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
    p(
      Data(
        ("style", "border: 1px solid black;"),
        ("onClick", "console.log('clicked')")
      ),
      "this paragraph has a border"
    )
  )
);

Console.WriteLine(document.Render(0));
