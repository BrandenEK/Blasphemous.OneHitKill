using Gameplay.GameControllers.Entities;
using Gameplay.GameControllers.Penitent.Damage;
using HarmonyLib;

namespace OneHitKO
{
    [HarmonyPatch(typeof(PenitentDamageArea), nameof(PenitentDamageArea.TakeDamage))]
    public class DamageArea_Patch
    {
        public static void Prefix(ref Hit hit)
        {
            hit.DamageAmount = 1000;
        }
    }
}
