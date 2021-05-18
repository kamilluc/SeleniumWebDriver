using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumWebDriver.Utils
{
    internal static class WaitTimer
    {
        public static void WaitTime(int ms = 4000)
        {
            Thread.Sleep(ms);
        }
    }
}
