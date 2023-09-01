using OneOf;

namespace HtmlTagHelpers;

public partial class HtmlContent
  : OneOfBase<
    string,
    HData,
    (string Key, string? Value),
    HtmlTag,
    HtmlTag[],
    HtmlContent[]
  >
{
  protected HtmlContent(
    OneOf<
      string,
      HData,
      (string Key, string? Value),
      HtmlTag,
      HtmlTag[],
      HtmlContent[]
    > input
  )
    : base(input) { }

  public static implicit operator HtmlContent(string _) => new(_);

  public static implicit operator HtmlContent(HData _) => new(_);

  public static implicit operator HtmlContent((string Key, string? Value) _) =>
    new(_);

  public static implicit operator HtmlContent(HtmlTag _) => new(_);

  public static implicit operator HtmlContent(HtmlTag[] _) => new(_);

  public static implicit operator HtmlContent(HtmlContent[] _) => new(_);
}
