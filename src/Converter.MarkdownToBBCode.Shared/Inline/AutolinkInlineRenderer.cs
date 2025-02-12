using Markdig.Syntax.Inlines;

namespace Converter.MarkdownToBBCode.Shared.Inline;

public class AutolinkInlineRenderer : BBCodeObjectRenderer<AutolinkInline>
{
    protected override void Write(BBCodeRenderer renderer, AutolinkInline obj)
    {
        var url = obj.Url;
        renderer.Write($"[url={url}]{url}[/url]");
    }
}