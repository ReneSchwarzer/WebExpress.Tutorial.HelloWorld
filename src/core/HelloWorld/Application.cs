using WebExpress.WebApplication;
using WebExpress.WebAttribute;

namespace HelloWorld
{
    [Id("2884C459-0E73-42C0-A3BB-F9E4D8CCBA00")]
    [Name("54285621-C031-4E82-AE32-FF5E5974AED9:app.name")]
    [Description("54285621-C031-4E82-AE32-FF5E5974AED9:app.description")]
    [Icon("/assets/img/helloworld.svg")]
    [AssetPath("/")]
    [ContextPath("/helloworld")]
    public sealed class Application : IApplication
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Application()
        {
        }

        /// <summary>
        /// Initialization of the application. Here, for example, managed resources can be loaded. 
        /// </summary>
        /// <param name="context">The context that applies to the execution of the application</param>
        public void Initialization(IApplicationContext context)
        {
        }

        /// <summary>
        /// Called when the application starts working. The call is concurrent. 
        /// </summary>
        public void Run()
        {
        }

        /// <summary>
        /// Release unmanaged resources that have been reserved during use.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
