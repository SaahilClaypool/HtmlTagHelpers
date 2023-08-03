namespace HFunc;

public static partial class TagHelpers
{
  public static HData Data(params (string Key, string Value)[] values)
  {
    return new HData(values);
  }

  public static HtmlTag H(string tag, params object[] childrenOrProps)
  {
    List<(string Key, string Value)> props = new();
    List<object> childrenItems = new();
    foreach (var item in childrenOrProps)
    {
      if (item is (string key, string value))
        props.Add((key, value));
      else
        childrenItems.Add(item);
    }
    return new(tag, new HData(props), childrenItems);
    
  }
  
  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;
}