using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Projectiles.Melee
{
    class SkylineProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skyline");
        }
        public override void SetDefaults()
        {
			projectile.tileCollide = true;
            projectile.hostile = false;
			projectile.friendly = true;
            projectile.ignoreWater = false;
			projectile.melee = true;
            projectile.width = 22;
            projectile.height = 22;
            projectile.aiStyle = 1;
            projectile.penetrate = 3;
            projectile.timeLeft = 500;
            aiType = ProjectileID.Bullet;
        }
        public override void AI()
        {
            Dust dust;
            Vector2 position = projectile.position;
            dust = Main.dust[Dust.NewDust(position, 22, 22, 60, 0f, 0f, 0, new Color(0, 217, 255), 1f)];
            dust.noGravity = true;

            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.55f;
            projectile.ai[1]++;
            if (projectile.ai[1] >= 20f)
            {
                for (int i = 0; i < 2; i++)
                {
                    Projectile proj = Projectile.NewProjectileDirect(projectile.Center, projectile.velocity, ProjectileID.HarpyFeather, projectile.damage / 2, 2f, Main.myPlayer);
                    Vector2 rotatedVelocity = i == 0 ? proj.velocity.RotatedBy(MathHelper.PiOver2) : proj.velocity.RotatedBy(-MathHelper.PiOver2);
                    proj.velocity = rotatedVelocity;
                    proj.hostile = false;
                    proj.friendly = true;
                }
                projectile.ai[1] = 0f;
				projectile.netUpdate = true;
            }
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Grass, projectile.Center);
            for(int i = 0; i < 10; i++)
            {
                Dust.NewDust(projectile.Center, 22, 22, ModContent.DustType<FeatherDust>(), 0, 1);
            }
        }
    }
}
