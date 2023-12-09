using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebPlugin;

namespace HelloWorld
{
    [Name("HelloWorld:plugin.name")]
    [Description("HelloWorld:plugin.description")]
    [Icon("/assets/img/helloworld.svg")]
    [Dependency("webexpress.webui")]
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
