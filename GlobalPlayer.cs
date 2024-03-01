using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JojosCaesarSound;

public class GlobalPlayer : ModPlayer
{
    public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust,
        ref PlayerDeathReason damageSource)
    {
        if (damageSource.SourceProjectileType == ProjectileID.Boulder)
        {
            SoundStyle caesarSound = new SoundStyle("JojosCaesarSound/Sounds/caesar")
                { Volume = 3.0f, MaxInstances = 1 };
            SoundEngine.PlaySound(caesarSound, Player.position);
        }
        {
            return base.PreKill(damage, hitDirection, pvp, ref playSound, ref genDust, ref damageSource);
        }
    }
}