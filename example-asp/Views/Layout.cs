namespace example_asp;

public partial class Views(IServiceProvider services)
{
  public Html Layout(params Html[] content)
  {
    return html()(
      head()(
        Raw(
          """
          <script src="https://unpkg.com/htmx.org@1.9.6"></script>
          <script src="//unpkg.com/alpinejs" defer></script>
          <script src="https://unpkg.com/htmx.org/dist/ext/alpine-morph.js"></script>
          <link href="/app.css" rel="stylesheet">
          """
        ),
        If(
          services.GetRequiredService<IWebHostEnvironment>().IsDevelopment(),
          script(src("/_framework/aspnetcore-browser-refresh.js"))(),
          Html.Empty
        )
      ),
      body()(content)
    );
  }
}
