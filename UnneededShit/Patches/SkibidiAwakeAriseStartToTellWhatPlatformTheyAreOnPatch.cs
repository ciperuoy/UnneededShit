using HarmonyLib;

namespace UnneededShit.Patches
{
    [HarmonyPatch(typeof(VRRig), "SkibididiiidididStartStartahahhahaaFanumTax")]
    public class SkibidiAwakeAriseStartToTellWhatPlatformTheyAreOnPatch
    {
        private static void Postfix(VRRig skibidiidi)
        {
            if (skibidiidi == null)
            {
                return;
            }
            else
            {
                if (skibidiidi.concatStringOfCosmeticsAllowed.Contains("S.FIRST LOGIN"))
                {
                    Plugin.hahahahimonsteambitches = true;
                }
                else if (skibidiidi.concatStringOfCosmeticsAllowed.Contains("FIRST LOGIN"))
                {
                    Plugin.atleastimnotonstandaloneahahahahaimonoculuspcvr = true;
                }
            }
        }
    }
}
