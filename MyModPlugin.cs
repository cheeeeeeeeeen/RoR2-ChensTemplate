#undef DEBUG

using BepInEx;
using BepInEx.Logging;
using R2API.Utils;

namespace My.Mod.Namespace
{
    [BepInPlugin(ModGuid, ModName, ModVer)]
    [BepInDependency(R2API.R2API.PluginGUID, R2API.R2API.PluginVersion)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [R2APISubmoduleDependency("SomeAPI")]
    public class MyModPluginPlugin : BaseUnityPlugin
    {
        public const string ModVer =
#if DEBUG
            "0." +
#endif
            "0.0.1";

        public const string ModName = "MyModName";
        public const string ModGuid = "com.Chen.MyModName";

        public static ManualLogSource _logger;

        private void Awake()
        {
            _logger = Logger;

#if DEBUG
            Logger.LogWarning("Running test build with debug enabled!");
            On.RoR2.Networking.GameNetworkManager.OnClientConnect += (self, user, t) => { };
#endif

            //using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ChensTemplate.mymod_assets"))
            //{
            //    var bundle = AssetBundle.LoadFromStream(stream);
            //    var provider = new AssetBundleResourcesProvider("@ChensGradiusMod", bundle);
            //    ResourcesAPI.AddProvider(provider);
            //}

            //using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ChensTemplate.mymod_soundbank.bnk"))
            //{
            //    var bytes = new byte[stream.Length];
            //    stream.Read(bytes, 0, bytes.Length);
            //    SoundAPI.SoundBanks.Add(bytes);
            //}
        }
    }
}