namespace HtmlTagHelpers;

#pragma warning disable IDE1006
public static partial class TagHelpers
{
  /// <summary>a	Defines a hyperlink</summary>
  public static HtmlTag a(params object[] children) => H("a", children);

  /// <summary>abbr	Defines an abbreviation or an acronym</summary>
  public static HtmlTag abbr(params object[] children) => H("abbr", children);

  /// <summary>address	Defines contact information for the author/owner of a document</summary>
  public static HtmlTag address(params object[] children) =>
    H("address", children);

  /// <summary>area	Defines an area inside an image map</summary>
  public static HtmlTag area(params object[] children) => H("area", children);

  /// <summary>article	Defines an article</summary>
  public static HtmlTag article(params object[] children) =>
    H("article", children);

  /// <summary>aside	Defines content aside from the page content</summary>
  public static HtmlTag aside(params object[] children) => H("aside", children);

  /// <summary>audio	Defines embedded sound content</summary>
  public static HtmlTag audio(params object[] children) => H("audio", children);

  /// <summary>b	Defines bold text</summary>
  public static HtmlTag b(params object[] children) => H("b", children);

  /// <summary>base	Specifies the base URL/target for all relative URLs in a document</summary>
  public static HtmlTag @base(params object[] children) => H("base", children);

  /// <summary>bdi	Isolates a part of text that might be formatted in a different direction from other text outside it</summary>
  public static HtmlTag bdi(params object[] children) => H("bdi", children);

  /// <summary>bdo	Overrides the current text direction</summary>
  public static HtmlTag bdo(params object[] children) => H("bdo", children);

  /// <summary>blockquote	Defines a section that is quoted from another source</summary>
  public static HtmlTag blockquote(params object[] children) =>
    H("blockquote", children);

  /// <summary>body	Defines the document's body</summary>
  public static HtmlTag body(params object[] children) => H("body", children);

  /// <summary>br	Defines a single line break</summary>
  public static HtmlTag br(params object[] children) => H("br", children);

  /// <summary>button	Defines a clickable button</summary>
  public static HtmlTag button(params object[] children) =>
    H("button", children);

  /// <summary>canvas	Used to draw graphics, on the fly, via scripting (usually JavaScript)</summary>
  public static HtmlTag canvas(params object[] children) =>
    H("canvas", children);

  /// <summary>caption	Defines a table caption</summary>
  public static HtmlTag caption(params object[] children) =>
    H("caption", children);

  /// <summary>cite	Defines the title of a work</summary>
  public static HtmlTag cite(params object[] children) => H("cite", children);

  /// <summary>code	Defines a piece of computer code</summary>
  public static HtmlTag code(params object[] children) => H("code", children);

  /// <summary>col	Specifies column properties for each column within a <colgroup> element</summary>
  public static HtmlTag col(params object[] children) => H("col", children);

  /// <summary>colgroup	Specifies a group of one or more columns in a table for formatting</summary>
  public static HtmlTag colgroup(params object[] children) =>
    H("colgroup", children);

  /// <summary>data	Adds a machine-readable translation of a given content</summary>
  public static HtmlTag data(params object[] children) => H("data", children);

  /// <summary>datalist	Specifies a list of pre-defined options for input controls</summary>
  public static HtmlTag datalist(params object[] children) =>
    H("datalist", children);

  /// <summary>dd	Defines a description/value of a term in a description list</summary>
  public static HtmlTag dd(params object[] children) => H("dd", children);

  /// <summary>del	Defines text that has been deleted from a document</summary>
  public static HtmlTag del(params object[] children) => H("del", children);

  /// <summary>details	Defines additional details that the user can view or hide</summary>
  public static HtmlTag details(params object[] children) =>
    H("details", children);

  /// <summary>dfn	Specifies a term that is going to be defined within the content</summary>
  public static HtmlTag dfn(params object[] children) => H("dfn", children);

  /// <summary>dialog	Defines a dialog box or window</summary>
  public static HtmlTag dialog(params object[] children) =>
    H("dialog", children);

  /// <summary>div	Defines a section in a document</summary>
  public static HtmlTag div(params object[] children) => H("div", children);

  /// <summary>dl	Defines a description list</summary>
  public static HtmlTag dl(params object[] children) => H("dl", children);

  /// <summary>dt	Defines a term/name in a description list</summary>
  public static HtmlTag dt(params object[] children) => H("dt", children);

  /// <summary>em	Defines emphasized text</summary>
  public static HtmlTag em(params object[] children) => H("em", children);

  /// <summary>embed	Defines a container for an external application</summary>
  public static HtmlTag embed(params object[] children) => H("embed", children);

  /// <summary>fieldset	Groups related elements in a form</summary>
  public static HtmlTag fieldset(params object[] children) =>
    H("fieldset", children);

  /// <summary>figcaption	Defines a caption for a <figure> element</summary>
  public static HtmlTag figcaption(params object[] children) =>
    H("figcaption", children);

  /// <summary>figure	Specifies self-contained content</summary>
  public static HtmlTag figure(params object[] children) =>
    H("figure", children);

  /// <summary>footer	Defines a footer for a document or section</summary>
  public static HtmlTag footer(params object[] children) =>
    H("footer", children);

  /// <summary>form	Defines an HTML form for user input</summary>
  public static HtmlTag form(params object[] children) => H("form", children);

  /// <summary>h1 to <h6>	Defines HTML headings</summary>
  public static HtmlTag h1(params object[] children) => H("h1", children);

  /// <summary>head	Contains metadata/information for the document</summary>
  public static HtmlTag head(params object[] children) => H("head", children);

  /// <summary>header	Defines a header for a document or section</summary>
  public static HtmlTag header(params object[] children) =>
    H("header", children);

  /// <summary>hr	Defines a thematic change in the content</summary>
  public static HtmlTag hr(params object[] children) => H("hr", children);

  /// <summary>html	Defines the root of an HTML document</summary>
  public static HtmlTag html(params object[] children) => H("html", children);

  /// <summary>i	Defines a part of text in an alternate voice or mood</summary>
  public static HtmlTag i(params object[] children) => H("i", children);

  /// <summary>iframe	Defines an inline frame</summary>
  public static HtmlTag iframe(params object[] children) =>
    H("iframe", children);

  /// <summary>img	Defines an image</summary>
  public static HtmlTag img(params object[] children) => H("img", children);

  /// <summary>input	Defines an input control</summary>
  public static HtmlTag input(params object[] children) => H("input", children);

  /// <summary>ins	Defines a text that has been inserted into a document</summary>
  public static HtmlTag ins(params object[] children) => H("ins", children);

  /// <summary>kbd	Defines keyboard input</summary>
  public static HtmlTag kbd(params object[] children) => H("kbd", children);

  /// <summary>label	Defines a label for an <input> element</summary>
  public static HtmlTag label(params object[] children) => H("label", children);

  /// <summary>legend	Defines a caption for a <fieldset> element</summary>
  public static HtmlTag legend(params object[] children) =>
    H("legend", children);

  /// <summary>li	Defines a list item</summary>
  public static HtmlTag li(params object[] children) => H("li", children);

  /// <summary>link	Defines the relationship between a document and an external resource (most used to link to style sheets)</summary>
  public static HtmlTag link(params object[] children) => H("link", children);

  /// <summary>main	Specifies the main content of a document</summary>
  public static HtmlTag main(params object[] children) => H("main", children);

  /// <summary>map	Defines an image map</summary>
  public static HtmlTag map(params object[] children) => H("map", children);

  /// <summary>mark	Defines marked/highlighted text</summary>
  public static HtmlTag mark(params object[] children) => H("mark", children);

  /// <summary>meta	Defines metadata about an HTML document</summary>
  public static HtmlTag meta(params object[] children) => H("meta", children);

  /// <summary>meter	Defines a scalar measurement within a known range (a gauge)</summary>
  public static HtmlTag meter(params object[] children) => H("meter", children);

  /// <summary>nav	Defines navigation links</summary>
  public static HtmlTag nav(params object[] children) => H("nav", children);

  /// <summary>object	Defines a container for an external application</summary>
  public static HtmlTag @object(params object[] children) =>
    H("object", children);

  /// <summary>ol	Defines an ordered list</summary>
  public static HtmlTag ol(params object[] children) => H("ol", children);

  /// <summary>optgroup	Defines a group of related options in a drop-down list</summary>
  public static HtmlTag optgroup(params object[] children) =>
    H("optgroup", children);

  /// <summary>option	Defines an option in a drop-down list</summary>
  public static HtmlTag option(params object[] children) =>
    H("option", children);

  /// <summary>output	Defines the result of a calculation</summary>
  public static HtmlTag output(params object[] children) =>
    H("output", children);

  /// <summary>p	Defines a paragraph</summary>
  public static HtmlTag p(params object[] children) => H("p", children);

  /// <summary>param	Defines a parameter for an object</summary>
  public static HtmlTag param(params object[] children) => H("param", children);

  /// <summary>picture	Defines a container for multiple image resources</summary>
  public static HtmlTag picture(params object[] children) =>
    H("picture", children);

  /// <summary>pre	Defines preformatted text</summary>
  public static HtmlTag pre(params object[] children) => H("pre", children);

  /// <summary>progress	Represents the progress of a task</summary>
  public static HtmlTag progress(params object[] children) =>
    H("progress", children);

  /// <summary>q	Defines a short quotation</summary>
  public static HtmlTag q(params object[] children) => H("q", children);

  /// <summary>rp	Defines what to show in browsers that do not support ruby annotations</summary>
  public static HtmlTag rp(params object[] children) => H("rp", children);

  /// <summary>rt	Defines an explanation/pronunciation of characters (for East Asian typography)</summary>
  public static HtmlTag rt(params object[] children) => H("rt", children);

  /// <summary>ruby	Defines a ruby annotation (for East Asian typography)</summary>
  public static HtmlTag ruby(params object[] children) => H("ruby", children);

  /// <summary>s	Defines text that is no longer correct</summary>
  public static HtmlTag s(params object[] children) => H("s", children);

  /// <summary>samp	Defines sample output from a computer program</summary>
  public static HtmlTag samp(params object[] children) => H("samp", children);

  /// <summary>script	Defines a client-side script</summary>
  public static HtmlTag script(params object[] children) =>
    H("script", children);

  /// <summary>section	Defines a section in a document</summary>
  public static HtmlTag section(params object[] children) =>
    H("section", children);

  /// <summary>select	Defines a drop-down list</summary>
  public static HtmlTag select(params object[] children) =>
    H("select", children);

  /// <summary>small	Defines smaller text</summary>
  public static HtmlTag small(params object[] children) => H("small", children);

  /// <summary>source	Defines multiple media resources for media elements (<video> and <audio>)</summary>
  public static HtmlTag source(params object[] children) =>
    H("source", children);

  /// <summary>span	Defines a section in a document</summary>
  public static HtmlTag span(params object[] children) => H("span", children);

  /// <summary>strong	Defines important text</summary>
  public static HtmlTag strong(params object[] children) =>
    H("strong", children);

  /// <summary>style	Defines style information for a document</summary>
  public static HtmlTag style(params object[] children) => H("style", children);

  /// <summary>sub	Defines subscripted text</summary>
  public static HtmlTag sub(params object[] children) => H("sub", children);

  /// <summary>summary	Defines a visible heading for a <details> element</summary>
  public static HtmlTag summary(params object[] children) =>
    H("summary", children);

  /// <summary>sup	Defines superscripted text</summary>
  public static HtmlTag sup(params object[] children) => H("sup", children);

  /// <summary>svg	Defines a container for SVG graphics</summary>
  public static HtmlTag svg(params object[] children) => H("svg", children);

  /// <summary>table	Defines a table</summary>
  public static HtmlTag table(params object[] children) => H("table", children);

  /// <summary>tbody	Groups the body content in a table</summary>
  public static HtmlTag tbody(params object[] children) => H("tbody", children);

  /// <summary>td	Defines a cell in a table</summary>
  public static HtmlTag td(params object[] children) => H("td", children);

  /// <summary>template	Defines a container for content that should be hidden when the page loads</summary>
  public static HtmlTag template(params object[] children) =>
    H("template", children);

  /// <summary>textarea	Defines a multiline input control (text area)</summary>
  public static HtmlTag textarea(params object[] children) =>
    H("textarea", children);

  /// <summary>tfoot	Groups the footer content in a table</summary>
  public static HtmlTag tfoot(params object[] children) => H("tfoot", children);

  /// <summary>th	Defines a header cell in a table</summary>
  public static HtmlTag th(params object[] children) => H("th", children);

  /// <summary>thead	Groups the header content in a table</summary>
  public static HtmlTag thead(params object[] children) => H("thead", children);

  /// <summary>time	Defines a specific time (or datetime)</summary>
  public static HtmlTag time(params object[] children) => H("time", children);

  /// <summary>title	Defines a title for the document</summary>
  public static HtmlTag title(params object[] children) => H("title", children);

  /// <summary>tr	Defines a row in a table</summary>
  public static HtmlTag tr(params object[] children) => H("tr", children);

  /// <summary>track	Defines text tracks for media elements (<video> and <audio>)</summary>
  public static HtmlTag track(params object[] children) => H("track", children);

  /// <summary>u	Defines some text that is unarticulated and styled differently from normal text</summary>
  public static HtmlTag u(params object[] children) => H("u", children);

  /// <summary>ul	Defines an unordered list</summary>
  public static HtmlTag ul(params object[] children) => H("ul", children);

  /// <summary>var	Defines a variable</summary>
  public static HtmlTag var(params object[] children) => H("var", children);

  /// <summary>video	Defines embedded video content</summary>
  public static HtmlTag video(params object[] children) => H("video", children);

  /// <summary>wbr	Defines a possible line-break</summary>
  public static HtmlTag wbr(params object[] children) => H("wbr", children);
}
#pragma warning restore IDE1006