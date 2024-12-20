﻿using WebExpress.WebCore.Internationalization;
using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebHtml;
using WebExpress.WebCore.WebPage;
using WebExpress.WebCore.WebScope;

namespace HelloWorld.WebPage
{
    [Title("HelloWorld:homepage.label")]
    [Segment(null, "HelloWorld:homepage.label")]
    public sealed class HomePage : IPage<VisualTree>, IScope
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="pageContext">The page context.</param>
        public HomePage(IPageContext pageContext)
        {
        }

        /// <summary>
        /// Processing of the page.
        /// </summary>
        /// <param name="renderContext">The context for rendering the page.</param>
        /// <param name="visualTree">The visual tree to be rendered.</param>
        public void Process(IRenderContext renderContext, VisualTree visualTree)
        {
            visualTree.Favicons.Add(new Favicon(renderContext?.PageContext?.ApplicationContext?.ContextPath.Append("/assets/img/favicon.png")));
            visualTree.Content = new HtmlText(I18N.Translate("HelloWorld:homepage.text"));
        }

        /// <summary>
        /// Release unmanaged resources that have been reserved during use.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
