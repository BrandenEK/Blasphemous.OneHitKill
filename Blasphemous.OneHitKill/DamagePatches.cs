using Gameplay.GameControllers.Entities;
using Gameplay.GameControllers.Penitent.Damage;
using HarmonyLib;

namespace Blasphemous.OneHitKill;

/// <summary>
/// When taking damage, just set the value really high
/// </summary>
[HarmonyPatch(typeof(PenitentDamageArea), nameof(PenitentDamageArea.TakeDamage))]
class DamageArea_Patch
{
    public static void Prefix(ref Hit hit)
    {
        hit.DamageAmount = 1000;
    }
}
