namespace HtmlTagHelpers;

public static partial class TagHelpers
{
  public static readonly string? NO_VALUE = null;

  public static HData Data(params (string Key, string? Value)[] items) =>
    new(items);

  public static HtmlTag H(string tag, HData data, params object[] children)
  {
    return new(tag, data, children);
  }

  public static HtmlTag H(string tag, params object[] childrenOrProps)
  {
    List<(string Key, string? Value)> props = new(childrenOrProps.Length);
    List<object> childrenItems = new(childrenOrProps.Length);
    foreach (var item in childrenOrProps)
    {
      // since this is dotet standard, can't simply write
      // if (item is var (key, value))
      if (item is ValueTuple<string, string> tuple)
      {
        props.Add(tuple);
      }
      else
        childrenItems.Add(item);
    }
    return new(tag, new HData(props), childrenItems);
  }

  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;
}
