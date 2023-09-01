namespace HtmlTagHelpers;

public static partial class TagHelpers
{
  public static readonly string? NO_VALUE = null;

  public static HData Data(params (string Key, string? Value)[] items) =>
    new(items);

  public static HtmlTag H(string tag, params HtmlContent[] childrenOrProps)
  {
    List<(string Key, string? Value)> props = new(childrenOrProps.Length);
    List<object> childrenItems = new(childrenOrProps.Length);
    foreach (var item in childrenOrProps)
    {
      void HandleContent(HtmlContent content)
      {
        content.Switch(
          str => childrenItems.Add(str),
          hdata => props.AddRange(hdata.Values),
          tuple => props.Add(tuple),
          tag => childrenItems.Add(tag),
          tags => childrenItems.AddRange(tags),
          nestedContent => Each(nestedContent, HandleContent)
        );
      }
      HandleContent(item);
    }
    return new(tag, new HData(props), childrenItems);
  }

  public static HtmlTag[] Map<T>(
    this IEnumerable<T> items,
    Func<T, HtmlTag> map
  ) => items.Select(map).ToArray();

  public static HtmlTag[] Map<T>(
    this IEnumerable<T> items,
    Func<T, int, HtmlTag> map
  ) => items.Select(map).ToArray();

  public static HtmlTag If(bool condition, HtmlTag ifTrue, HtmlTag ifFalse) =>
    condition ? ifTrue : ifFalse;

  private static void Each<T>(IEnumerable<T> elements, Action<T> action)
  {
    foreach (var i in elements)
      action(i);
  }
}
