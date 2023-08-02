namespace HFunc;

public static partial class TagHelpers
{
  public static HData Data(params (string Key, string Value)[] values)
  {
    return new HData(values);
  }

  public static HtmlTag H(string tag, HData props, params object[] children) =>
    new(tag, props, children);

  public static HtmlTag H(string tag, params object[] children) =>
    new(tag, Data(), Children: children);
  
  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;
}