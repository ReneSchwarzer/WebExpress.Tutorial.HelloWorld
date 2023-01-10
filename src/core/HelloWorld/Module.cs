using WebExpress.WebAttribute;
using WebExpress.WebModule;

namespace HelloWorld
{
    [Id("89AE354B-A640-4BDA-AD77-6F23DB811277")]
    [Name("54285621-C031-4E82-AE32-FF5E5974AED9:module.name")]
    [Description("54285621-C031-4E82-AE32-FF5E5974AED9:module.description")]
    [Icon("/assets/img/helloworld.svg")]
    [AssetPath("/")]
    [ContextPath("/")]
    [Application("2884C459-0E73-42C0-A3BB-F9E4D8CCBA00")]
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
