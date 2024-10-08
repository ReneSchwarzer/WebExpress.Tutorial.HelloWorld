﻿using WebExpress.WebCore.Internationalization;
using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebHtml;
using WebExpress.WebCore.WebPage;
using WebExpress.WebCore.WebResource;
using WebExpress.WebCore.WebScope;
using WebExpress.WebUI.WebControl;
using WebExpress.WebUI.WebPage;

namespace HelloWorld.WebPage
{
    [Title("HelloWorld:homepage.label")]
    [Segment(null, "HelloWorld:homepage.label")]
    [ContextPath(null)]
    [Module<Module>]
    public sealed class HomePage : Page<RenderContextControl>, IScope
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public HomePage()
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
            context.VisualTree.Favicons.Add(new Favicon(context.ApplicationContext.ContextPath.Append("/assets/img/favicon.png")));
            context.VisualTree.Content.Add(new ControlText() { Text = InternationalizationManager.I18N("HelloWorld:homepage.text") });
        }
    }
}
