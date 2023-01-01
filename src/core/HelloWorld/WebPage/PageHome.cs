using WebExpress.Internationalization;
using WebExpress.UI.WebControl;
using WebExpress.UI.WebPage;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebPage;
using WebExpress.WebResource;

namespace HelloWorld.WebPage
{
    [Id("Log")]
    [Title("helloworld:homepage.label")]
    [Segment("", "helloworld:homepage.label")]
    [Path("")]
    [Module("HelloWorld")]
    [Context("general")]
    [Context("homepage")]
    public sealed class PageHome : Page<RenderContextControl>
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
            context.VisualTree.Content.Add(new ControlText() { Text = InternationalizationManager.I18N("helloworld:homepage.text") });
        }
    }
}
