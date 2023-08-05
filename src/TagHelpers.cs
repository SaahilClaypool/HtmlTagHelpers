namespace HtmlTagHelpers;

public static partial class TagHelpers
{
  public static readonly object? NO_VALUE = null;

  public static HtmlTag H(string tag, params object[] childrenOrProps)
  {
    List<(string Key, object? Value)> props = new(childrenOrProps.Length);
    List<object> childrenItems = new(childrenOrProps.Length);
    foreach (var item in childrenOrProps)
    {
      var itemType = item.GetType();
      // since this is dotet standard, can't simply write
      // if (item is var (key, value))
      if (
        itemType.Name.StartsWith("ValueTuple`")
        && itemType.IsValueType
        && itemType.IsGenericType
        && itemType.GenericTypeArguments.Count() == 2
      )
      {
        dynamic dyn = item;
        props.Add(((string)dyn.Item1, (object?)dyn.Item2));
      }
      else
        childrenItems.Add(item);
    }
    return new(tag, new HData(props), childrenItems);
  }

  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;
}
