using WebExpress.Internationalization;
using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace HelloWorld.WebPage
{
    [Id("Log")]
    [Title("helloworld:homepage.label")]
    [Segment("log", "helloworld:homepage.label")]
    [Path("/")]
    [Module("HelloWorld")]
    [Context("general")]
    [Context("homepage")]
    public sealed class PageHome : PageWebApp
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
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);

            context.VisualTree.Content.Primary.Add(new ControlText() { Text = InternationalizationManager.I18N(context, "Hello World!") });
        }
    }
}
