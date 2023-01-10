using WebExpress.WebAttribute;
using WebExpress.WebPlugin;

namespace HelloWorld
{
    [Id("54285621-C031-4E82-AE32-FF5E5974AED9")]
    [Name("54285621-C031-4E82-AE32-FF5E5974AED9:plugin.name")]
    [Description("54285621-C031-4E82-AE32-FF5E5974AED9:plugin.description")]
    [Icon("/assets/img/helloworld.svg")]
    public sealed class Plugin : IPlugin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Plugin()
        {
        }

        /// <summary>
        /// Initialization of the plugin. Here, for example, managed resources can be loaded. 
        /// </summary>
        /// <param name="context">The context that applies to the execution of the plugin</param>
        public void Initialization(IPluginContext context)
        {
        }

        /// <summary>
        /// Called when the plugin starts working. Run is called concurrently.
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
