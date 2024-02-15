using BepInEx;

namespace Blasphemous.OneHitKill;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "2.1.0")]
public class Main : BaseUnityPlugin
{
    public static OneHitKill OneHitKill { get; private set; }

    private void Start()
    {
        OneHitKill = new OneHitKill();
    }
}
