﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTest.Startup))]
namespace WebAppTest
{
    public partial class Startup
    {
        //another more comment
        //one more comment
        //Eric Test
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
