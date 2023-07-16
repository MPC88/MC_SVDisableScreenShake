using BepInEx;
using HarmonyLib;

namespace MC_SVDisableScreenshake
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Main : BaseUnityPlugin
    {
        public const string pluginGuid = "mc.starvalor.disablescreenshake";
        public const string pluginName = "SV Disable Screenshake";
        public const string pluginVersion = "1.0.0";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(Main));
        }

        [HarmonyPatch(typeof(CameraControl), nameof(CameraControl.Shake))]
        [HarmonyPrefix]
        public static bool CC_ShakePre()
        {
            return false;
        }

        [HarmonyPatch(typeof(CameraControl), nameof(CameraControl.ShakeBig))]
        [HarmonyPrefix]
        public static bool CC_ShakeBigPre()
        {
            return false;
        }
    }
}
