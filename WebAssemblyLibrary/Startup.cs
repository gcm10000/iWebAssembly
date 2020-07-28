using System;
using System.Collections.Generic;
using System.Text;

namespace WebAssemblyLibrary
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public StartUp(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SocketHub>("/SocketHub");
            });
        }
    }
}
