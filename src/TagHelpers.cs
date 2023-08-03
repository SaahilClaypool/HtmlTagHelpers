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
      if (item is ValueTuple<string, object?> tuple)
        props.Add(tuple);
      else
        childrenItems.Add(item);
    }
    return new(tag, new HData(props), childrenItems);
    
  }
  
  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;
}