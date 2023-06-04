using WebExpress.WebAttribute;
using WebExpress.WebModule;

namespace HelloWorld
{
    [WebExName("HelloWorld:module.name")]
    [WebExDescription("HelloWorld:module.description")]
    [WebExIcon("/assets/img/helloworld.svg")]
    [WebExAssetPath("/")]
    [WebExContextPath("/")]
    [WebExApplication<Application>]
    public sealed class Module : IModule
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Module()
        {
        }

        /// <summary>
        /// Initialization of the module. Here, for example, managed resources can be loaded. 
        /// </summary>
        /// <param name="context">The context that applies to the execution of the module</param>
        public void Initialization(IModuleContext context)
        {
        }

        /// <summary>
        /// Called when the module starts working. The call is concurrent.
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
