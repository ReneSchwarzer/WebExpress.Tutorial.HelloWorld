﻿using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebPlugin;

namespace HelloWorld
{
    /// <summary>
    /// Represents a WebExpress plugin.
    /// </summary>
    [Name("HelloWorld:plugin.name")]
    [Description("HelloWorld:plugin.description")]
    [Icon("/assets/img/helloworld.svg")]
    [Application<Application>()]
    public sealed class Plugin : IPlugin
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="context">The context that applies to the execution of the plugin</param>
        public Plugin(IPluginContext context)
        {
        }

        /// <summary>
        /// Called when the plugin starts working. Run is called concurrently.
        /// </summary>
        public void Run()
        {
        }
    }
}
