using BepInEx;
using HarmonyLib;

namespace replayEditor
{
    [BepInPlugin("com.jo912345.replayEditor", "replayEditor", PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony harmony = new Harmony("com.jo912345.hitboxVisualizePlugin");

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        public void OnDestroy()
        {
            harmony.UnpatchSelf();
            Logger.LogError($"{PluginInfo.PLUGIN_NAME} has been unloaded. (if you see this when starting the game, it's likely that `HideManagerGameObject = false` in `BepInEx.cfg`. please enable it!)");
        }
    }
}
