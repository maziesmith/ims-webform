﻿using Microsoft.Owin;
using Owin;
using IMSDBLayer;

[assembly: OwinStartupAttribute(typeof(InterventionManagementSystem.Startup))]
namespace InterventionManagementSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);

            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Setup DBsetup = new Setup(connstring);
        }
    }
}
