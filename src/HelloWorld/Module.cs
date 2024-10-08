﻿using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebModule;

namespace HelloWorld
{
    [Name("HelloWorld:module.name")]
    [Description("HelloWorld:module.description")]
    [Icon("/assets/img/helloworld.svg")]
    [AssetPath("/")]
    [ContextPath("/")]
    [Application<Application>]
    public sealed class Module : IModule
    {
        /// <summary>
        /// Initializes a new instance of the class.
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
