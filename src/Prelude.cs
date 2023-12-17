namespace HtmlTagHelpers;

using Eighty;

public delegate Html TagBuilder(params Html[] content);
public delegate TagBuilder TagAttributeBuilder(params Attr[] attrs);

public static partial class Prelude
{
  public static Html Map(IEnumerable<Html> html) => Html._(html);

  public static T If<T>(bool t, T val, Func<T> other) => t ? val : other();

  public static T If<T>(bool t, T val, T other) => t ? val : other;

  public static Html If(bool t, Html val, Html other) => t ? val : other;

  public static Attr Attr(string attr) => new Attr(attr);

  public static Attr Attr(string name, string value, bool escape = false) =>
    escape ? Attr(name, value) : Eighty.Attr.Raw(name, value);

  public static Html Raw(string html) => Html.Raw(html);

  public static TagAttributeBuilder Tag(string tagName) =>
    new TagAttrBuilderStruct(tagName).TagAttributeBuilder;

  public static readonly Html Empty = Html.Empty;

  record struct TagAttrBuilderStruct(string TagName)
  {
    public TagBuilder TagAttributeBuilder(params Attr[] attributes)
    {
      return Html.Tag(TagName, attributes)._;
    }
  }
}
