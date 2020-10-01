using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items.Weapons
{
	public class Cloud_Beam : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cloud Beam");
		}

		public override void SetDefaults() {
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.light = 5f;  
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.aiStyle = 8;
		}
		public override void AI()         
        {                                                         
        }
		
	}
}