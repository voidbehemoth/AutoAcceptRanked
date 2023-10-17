using System;

namespace AutoAcceptRanked.Utils
{
    // Not necessary for mod, just useful
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("[" + AutoAcceptRanked.ModInfo.PLUGIN_GUID + "] " + message); // Formatting is a style choice on the developer's part
        }
    }
}
