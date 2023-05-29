using WebExpress.WebApplication;
using WebExpress.WebAttribute;

namespace HelloWorld
{
    [WebExName("HelloWorld:app.name")]
    [WebExDescription("HelloWorld:app.description")]
    [WebExIcon("/assets/img/helloworld.svg")]
    [WebExAssetPath("/")]
    [WebExContextPath("/helloworld")]
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
