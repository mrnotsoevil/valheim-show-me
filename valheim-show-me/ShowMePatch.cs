using HarmonyLib;

namespace valheim_show_me
{
    [HarmonyPatch(typeof(ZNet), "Awake")]
    public class ShowMePatch
    {
        static void Postfix(ref bool ___m_publicReferencePosition)
        {
            ___m_publicReferencePosition = true;
        }
    }
}