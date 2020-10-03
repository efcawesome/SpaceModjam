using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Projectiles.Mage
{
    class CloudAtlasProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mystical Cloud");
        }
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.ignoreWater = false;
            projectile.timeLeft = 500;
            projectile.tileCollide = true;
            projectile.hostile = false;
            aiType = ProjectileID.Bullet;
        }
        public override void AI()
        {
            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position;
            dust = Main.dust[Terraria.Dust.NewDust(position, 32, 16, 1, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.noGravity = true;
        }
        public override void Kill(int timeLeft)
        {
            for(int i = 0; i < 5; i++)
            {
                Dust dust;
                Vector2 position = projectile.position;
                dust = Main.dust[Terraria.Dust.NewDust(position, 32, 16, 1, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                dust.noGravity = true;
            }
        }
    }
}
