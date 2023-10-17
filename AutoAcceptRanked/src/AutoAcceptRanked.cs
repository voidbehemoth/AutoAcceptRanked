using SML;

namespace AutoAcceptRanked
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
        {
            AutoAcceptRanked.Utils.Logger.Log(AutoAcceptRanked.ModInfoPLUGIN_NAME + "has loaded!");
        }
    }


    public static class ModInfo
    {
        public const string PLUGIN_GUID = "AutoAcceptRanked";

        public const string PLUGIN_NAME = "AutoAcceptRanked";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}