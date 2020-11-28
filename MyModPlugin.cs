#undef DEBUG

using BepInEx;
using Chen.Helpers.LogHelpers;
using R2API.Utils;
//using static Chen.Helpers.GeneralHelpers.AssetsManager;

namespace My.Mod.Namespace
{
    /// <summary>
    /// Description of the plugin.
    /// </summary>
    [BepInPlugin(ModGuid, ModName, ModVer)]
    [BepInDependency(R2API.R2API.PluginGUID, R2API.R2API.PluginVersion)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [R2APISubmoduleDependency("SomeAPI")]
    public class MyModPluginPlugin : BaseUnityPlugin
    {
        /// <summary>
        /// This mod's version.
        /// </summary>
        public const string ModVer =
#if DEBUG
            "0." +
#endif
            "0.0.1";

        /// <summary>
        /// This mod's name.
        /// </summary>
        public const string ModName = "MyModName";

        /// <summary>
        /// This mod's GUID.
        /// </summary>
        public const string ModGuid = "com.Chen.MyModName";

        internal static Log Log;

        private void Awake()
        {
            Log = new Log(Logger);

#if DEBUG
            Chen.Helpers.GeneralHelpers.MultiplayerTest.Enable(Log);
#endif
            //BundleInfo assetBundle = new BundleInfo("@ChensTemplate", "ChensTemplate.mymod_assets", BundleType.UnityAssetBundle);
            //BundleInfo soundBank = new BundleInfo("@ChensTemplate", "ChensTemplate.mymod_sounds.bnk", BundleType.WWiseSoundBank);
            //new AssetsManager(assetBundle, soundBank).RegisterAll();
        }
    }
}