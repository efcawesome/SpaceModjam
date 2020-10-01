using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Projectiles.Magic
{
	public class CloudBeamProj : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cloud Beam");
		}

		public override void SetDefaults() 
		{
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.magic = true;
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.aiStyle = 8;
			projectile.light = 5f;  
		}
	}
}