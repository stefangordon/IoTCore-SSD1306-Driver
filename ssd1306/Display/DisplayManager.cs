using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using Windows.System.Threading;

namespace SSD1306
{
    static class DisplayManager
    {
        private static Display display;

        public static void Init()
        {
            display = new SSD1306.Display();
            display.Init(true);
            Update();
        }

        static void Update()
        {
            display.ClearDisplayBuf();

            DrawBody();

            display.DisplayUpdate();
        }

        static void DrawBody()
        {
            // Row 0, and image
            display.WriteImageDisplayBuf(DisplayImages.Connected, 0, 0);

            // Row 1 - 3
            display.WriteLineDisplayBuf("Hello", 0, 1);
            display.WriteLineDisplayBuf("World", 0, 2);
        }     

    }
}
