using Home.Common;
using SML;
using HarmonyLib;
using Home.Messages.Outgoing;
using Services;

namespace AutoAcceptRanked
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
        {
            AutoAcceptRanked.Utils.Logger.Log(ModInfo.PLUGIN_NAME + "has loaded!");
        }
    }

    [HarmonyPatch(typeof(RankedTimerPanelController), nameof(RankedTimerPanelController.HandleAcceptRankedPopup)]
    public class RankedTimerPatch
    {
        [HarmonyPrefix]
        public static bool Prefix() 
        {
            RankedQueueResponseMessage msg = new RankedQueueResponseMessage(RankedQueueResponseMessage.ResponseType.AcceptQueue);
            Service.Home.NetworkService.SendMessage(msg);

            return false; // Skip original method
        }
    }

    public static class ModInfo
    {
        public const string PLUGIN_GUID = "AutoAcceptRanked";

        public const string PLUGIN_NAME = "Auto Accept Ranked";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}