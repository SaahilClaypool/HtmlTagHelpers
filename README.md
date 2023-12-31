# HTML Tag Helpers

DSL for building HTML - inspired by [nitter](https://github.com/zedeus/nitter/blob/master/src/views/feature.nim)

Example

```cs
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
    MButton(("onClick", "console.log('override')"))("test"),
    ul()(myElements.Select(i => li()(i)).ToArray())
  )
);

// example functional component
TagBuilder MButton(params Eighty.Attr[] content) =>
  button(content.Append(("onClick", "console.log('default')")).ToArray());

Console.WriteLine(document.ToString());
```

Outputs:

```html
<html><head><script>console.log('hello world')</script></head><body><h1>Title Page</h1><p>this is some content</p><span>true</span><p style="border: 1px solid black;" onClick="console.log(&#x27;clicked&#x27;)">this paragraph has a border</p><p hidden>hidden content</p><button onClick="console.log(&#x27;override&#x27;)" onClick="console.log(&#x27;default&#x27;)">test</button><ul><li>a</li><li>b</li><li>c</li></ul></body></html>
```

## Changelog

### 0.0.7

- Add h1 - h6 missing tag helpers

### 0.0.6

- Add [OneOf](https://github.com/mcintyre321/OneOf) generation to create typesafe methods

### 1.0.0

- use eighty as a base - change to partial function application as the interface

## build

```powershell
dotnet run --project .\generator\ > .\src\HtmlTagHelpers.cs && dotnet csharpier .
```
