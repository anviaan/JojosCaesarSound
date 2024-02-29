﻿using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace JojosCaesarSound;

public class GlobalPlayer: ModPlayer
{
    public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
    {
        if (proj.type == ProjectileID.Boulder)
        {
            SoundStyle caesarSound = new SoundStyle("JojosCaesarSound/Sounds/caesar");
            SoundEngine.PlaySound( caesarSound, Player.position);
        }
    }
}