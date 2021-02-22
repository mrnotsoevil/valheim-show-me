using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace valheim_show_me
{
    [BepInPlugin("de.mrnotsoevil.valheim.show-me", "Valheim Show Me", "1.0.0.0")]
    public class ValheimShowMePlugin : BaseUnityPlugin
    {
        public ValheimShowMePlugin()
        {
            
        }

        public void Awake()
        {
            Debug.Log("[Valheim Show Me!] Making player show on map by default ...");
            Harmony.CreateAndPatchAll(typeof(ShowMePatch));
        }
    }
}