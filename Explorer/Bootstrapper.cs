﻿using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Explorer
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            StaticConfiguration.DisableErrorTraces = false;
            base.ApplicationStartup(container, pipelines);
        }
    }
}