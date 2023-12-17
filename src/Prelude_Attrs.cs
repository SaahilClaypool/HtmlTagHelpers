namespace HtmlTagHelpers;

using Eighty;

public static partial class Prelude
{
  public static Attr clss(string name) => new("class", name);

  public static Attr id(string name) => new("id", name);

  public static Attr name(string name) => new("name", name);

  public static Attr value(object? name) =>
    new("value", name?.ToString() ?? string.Empty);

  public static Attr type(string name) => new("type", name);

  public static Attr href(string name) => new("href", name);

  public static Attr src(string name) => new("src", name);
}
