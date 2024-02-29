using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace JojosCaesarSound;

public class MyPlayer: ModPlayer
{
    public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
    {
        if (proj.type == ProjectileID.Boulder && Player.statLife <= 0)
        {
            SoundStyle caesarSound = new SoundStyle("JojosCaesarSound/Sounds/caesar.wav");
            SoundEngine.PlaySound(caesarSound, Player.position);
        }
    }
}