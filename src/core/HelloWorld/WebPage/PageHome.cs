using WebExpress.Internationalization;
using WebExpress.UI.WebControl;
using WebExpress.UI.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebPage;
using WebExpress.WebResource;

namespace HelloWorld.WebPage
{
    [Id("6D270CFE-EDB1-46BF-9014-6DD87BB942A8")]
    [Title("helloworld:homepage.label")]
    [Segment("", "helloworld:homepage.label")]
    [Path("")]
    [Module("89AE354B-A640-4BDA-AD77-6F23DB811277")]
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
