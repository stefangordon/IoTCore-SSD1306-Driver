using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.System.Threading;
using Windows.Devices.Gpio;
using Windows.ApplicationModel.Background;
using Devkoes.Restup.WebServer;
using Devkoes.Restup.WebServer.Rest;
using Devkoes.Restup.WebServer.Http;
using Devkoes.Restup.WebServer.File;

namespace SSD1306
{
    public sealed class StartupTask : IBackgroundTask
    {
        BackgroundTaskDeferral deferral;

        private const int CONTROL_X = 23;

        public async void Run(IBackgroundTaskInstance taskInstance)
        {           
            // Display
            DisplayManager.Init();
          
        }


    }
}
