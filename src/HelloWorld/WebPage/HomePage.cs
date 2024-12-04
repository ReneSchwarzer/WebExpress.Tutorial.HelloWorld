using WebExpress.WebCore.Internationalization;
using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebHtml;
using WebExpress.WebCore.WebPage;
using WebExpress.WebCore.WebScope;

namespace HelloWorld.WebPage
{
    [Title("HelloWorld:homepage.label")]
    [Segment(null, "HelloWorld:homepage.label")]
    [ContextPath(null)]
    public sealed class HomePage : IPage<RenderContext>, IScope
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="pageContext">The page context.</param>
        public HomePage(IPageContext pageContext)
        {
        }

        /// <summary>
        /// Redirects to the specified URI.
        /// </summary>
        /// <param name="uri">The URI to redirect to.</param>
        public void Redirecting(string uri)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Processing of the page.
        /// </summary>
        /// <param name="renderContext">The context for rendering the page.</param>
        public void Process(IRenderContext renderContext)
        {
            renderContext.VisualTree.Favicons.Add(new Favicon(renderContext?.PageContext?.ApplicationContext?.ContextPath.Append("/assets/img/favicon.png")));
            renderContext.VisualTree.Content = new HtmlText(I18N.Translate("HelloWorld:homepage.text"));
        }

        /// <summary>
        /// Release unmanaged resources that have been reserved during use.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
