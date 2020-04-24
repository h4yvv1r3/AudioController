using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Windows.Forms;

namespace WebAudioController
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string exePath = Path.GetDirectoryName(Application.ExecutablePath);

            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);

            app.MapSignalR();

#if DEBUG
            var physicalFileSystem = new PhysicalFileSystem(@"C:\share\DJ2\WebAudioController\Web");
#else
            var physicalFileSystem = new PhysicalFileSystem(exePath + "\\Web");
#endif

            var options = new FileServerOptions
            {
                EnableDefaultFiles = true,
                FileSystem = physicalFileSystem,
                EnableDirectoryBrowsing = true
            };
            options.StaticFileOptions.FileSystem = physicalFileSystem;
            options.StaticFileOptions.ServeUnknownFileTypes = true;
            options.DefaultFilesOptions.DefaultFileNames = new[] { "index.html" };
            app.UseFileServer(options);
        }
    }
}
