﻿var tags = new[]
{
  "a",
  "abbr",
  "address",
  "area",
  "article",
  "aside",
  "audio",
  "b",
  "@base",
  "bdi",
  "bdo",
  "blockquote",
  "body",
  "br",
  "button",
  "canvas",
  "caption",
  "cite",
  "code",
  "col",
  "colgroup",
  "data",
  "datalist",
  "dd",
  "del",
  "details",
  "dfn",
  "dialog",
  "div",
  "dl",
  "dt",
  "em",
  "embed",
  "fieldset",
  "figcaption",
  "figure",
  "footer",
  "form",
  "h1",
  "head",
  "header",
  "hr",
  "html",
  "i",
  "iframe",
  "img",
  "input",
  "ins",
  "kbd",
  "label",
  "legend",
  "li",
  "link",
  "main",
  "map",
  "mark",
  "meta",
  "meter",
  "nav",
  "@object",
  "ol",
  "optgroup",
  "option",
  "output",
  "p",
  "param",
  "picture",
  "pre",
  "progress",
  "q",
  "rp",
  "rt",
  "ruby",
  "s",
  "samp",
  "script",
  "section",
  "select",
  "small",
  "source",
  "span",
  "strong",
  "style",
  "sub",
  "summary",
  "sup",
  "svg",
  "table",
  "tbody",
  "td",
  "template",
  "textarea",
  "tfoot",
  "th",
  "thead",
  "time",
  "title",
  "tr",
  "track",
  "u",
  "ul",
  "var",
  "video",
  "wbr"
};

var output = $$"""
namespace HtmlTagHelpers;

#pragma warning disable IDE1006
public static partial class TagHelpers
{
    {{string.Join("\n\n", tags.Select(tag => $$"""

    /// <summary>{{Tag(tag)}}	Defines a hyperlink</summary>
    public static HtmlTag {{tag}}(params object[] children) =>
        H("{{Tag(tag)}}", children);

    /// <summary>Tag {{Tag(tag)}}</summary>
    public static HtmlTag {{tag}}(HData data, params object[] children) =>
        H("{{Tag(tag)}}", data, children);
"""))}}
}
""";

Console.WriteLine(output);

static string Tag(string tag) => tag.Replace("@", string.Empty);
