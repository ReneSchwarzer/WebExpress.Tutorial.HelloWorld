using WebExpress.Html;
using WebExpress.Internationalization;
using WebExpress.UI.WebControl;
using WebExpress.UI.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebPage;
using WebExpress.WebResource;
using WebExpress.WebScope;

namespace HelloWorld.WebPage
{
    [WebExTitle("HelloWorld:homepage.label")]
    [WebExSegment(null, "HelloWorld:homepage.label")]
    [WebExContextPath(null)]
    [WebExModule<Module>]
    public sealed class PageHome : Page<RenderContextControl>, IScope
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PageHome()
        {
        }

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="context">The context</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
        }

        /// <summary>
        /// Processing
        /// </summary>
        /// <param name="context">The context for rendering the page</param>
        public override void Process(RenderContextControl context)
        {
            context.VisualTree.Favicons.Add(new Favicon(context.Page.ApplicationContext.ContextPath.Append("/assets/img/favicon.png")));
            context.VisualTree.Content.Add(new ControlText() { Text = InternationalizationManager.I18N("HelloWorld:homepage.text") });
        }
    }
}
