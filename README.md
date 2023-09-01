# HTML Tag Helpers

DSL for building HTML - inspired by [nitter](https://github.com/zedeus/nitter/blob/master/src/views/feature.nim)

Example

```cs
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
    <button
      onClick="Console.log('override')"
    >
      test
    </button>
    <ul>
      <li>
        a
      </li>
      <li>
        b
      </li>
      <li>
        c
      </li>
    </ul>
  </body>
</html>
```

## Changelog

### 0.0.7

- Add h1 - h6 missing tag helpers

### 0.0.6

- Add [OneOf](https://github.com/mcintyre321/OneOf) generation to create typesafe methods
