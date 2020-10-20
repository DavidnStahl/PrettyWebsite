using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using PrettyWebsite.Business.RazorEngines;

namespace PrettyWebsite.Business.Initializers
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class CustomizedRenderingInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ViewEngines.Engines.Add(new PluginRazorViewEngine());
        }

        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }
    }
}