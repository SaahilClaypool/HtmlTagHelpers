# HTML Tag Helpers

DSL for building HTML - inspired by [nitter](https://github.com/zedeus/nitter/blob/master/src/views/feature.nim)

Example

```cs
global using static HtmlTagHelpers.TagHelpers;

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
    p(
      ("hidden", NO_VALUE),
      "hidden content"
    )
  )
);

Console.WriteLine(document.Render(0));
```

Outputs:

```html
<html>
  <head>
    <script>
      console.log('hello world')
    </script>
  </head>
  <body>
    <h1>
      Title Page
    </h1>
    <p>
      this is some content
    </p>
    <span>
      true
    </span>
    <p
      style="border: 1px solid black;"
      onClick="console.log('clicked')"
    >
      this paragraph has a border
    </p>
     <p
      hidden
     >
      hidden content
    </p>
  </body>
</html>
```
