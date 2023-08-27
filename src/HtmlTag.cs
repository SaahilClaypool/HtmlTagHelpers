namespace HtmlTagHelpers;

public record HtmlTag(string Tag, HData Props, ICollection<object> Children)
{
  static readonly Dictionary<int, string> _pads = new();

  static string GetPad(int? p)
  {
    if (p is null)
      return string.Empty;
    if (_pads.TryGetValue(p.Value, out var pad))
      return pad;
    pad =
      $"\n{string.Join("  ", Enumerable.Range(0, p.Value + 1).Select(_ => string.Empty))}";
    _pads[p.Value] = pad;
    return pad;
  }

  public string Render(int? indentLevel = null)
  {
    var pad = GetPad(indentLevel != null ? indentLevel.Value + 1 : null);
    var parentPad = GetPad(indentLevel);
    var children = string.Join(
      pad,
      Children.Select(
        c =>
          c is HtmlTag t
            ? t.Render(indentLevel is int level ? level + 1 : null)
            : c.ToString()
      )
    );
    if (indentLevel is null)
      return $"""
              <{Tag}{Props.Render(indentLevel)}>{children}</{Tag}>
              """;
    return $"""
            <{Tag}{Props.Render(indentLevel)}>{pad}{children}{parentPad}</{Tag}>
            """;
  }
}

public record HData(ICollection<(string Key, string? Value)> Values)
{
  /// <summary>
  /// Merge with another set of data, taking the "<paramref name="other"/>
  /// values on conflict
  /// </summary>
  /// <param name="other"></param>
  /// <returns></returns>
  public HData Merge(HData other) =>
    new(
      Values
        .Concat(other.Values)
        .GroupBy(x => x.Key)
        .Select(x => (x.Key, x.Last().Value))
        .ToList()
    );

  static readonly Dictionary<int, string> _pads = new();

  static string GetPad(int? p)
  {
    if (p is null)
      return "\n";
    if (_pads.TryGetValue(p.Value, out var pad))
      return pad;
    pad =
      $"\n{string.Join("  ", Enumerable.Range(0, p.Value + 1).Select(_ => string.Empty))}";
    _pads[p.Value] = pad;
    return pad;
  }

  public string Render(int? indentLevel = 0)
  {
    if (Values.Count == 0)
      return string.Empty;
    var renderedValues = Values.Select(
      kvp => kvp.Value != null ? $"{kvp.Key}=\"{kvp.Value}\"" : kvp.Key
    );
    if (indentLevel is null)
      return " " + string.Join(" ", renderedValues);

    var pad = GetPad(indentLevel != null ? indentLevel.Value + 1 : null);
    var parentPad = GetPad(indentLevel);
    return $"{pad}{string.Join(pad, renderedValues)}{parentPad}";
  }
}
