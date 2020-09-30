using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.NPCs.Enemies
{
    class SlimeUfo : ModNPC
    {
        bool shootAttack = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alien Slime U.F.O.");
        }
        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 46;
            npc.damage = 20;
            npc.lifeMax = 250;
            npc.defense = 15;
            npc.knockBackResist = 0.5f;
            npc.value = 100;
            npc.aiStyle = -1;
            npc.npcSlots = 1;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
        }
        public override void AI()
        {
            npc.TargetClosest(true);
            if (!shootAttack) npc.ai[0]++;
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;
            npc.netAlways = true;
            if (npc.ai[0] >= 60 && Math.Abs(target.X - npc.Center.X) < 5)
            {
                shootAttack = true;
                npc.ai[0] = 0;
            }
            if(shootAttack)
            {
                npc.velocity = Vector2.Zero;
                npc.ai[1]++;
                if (npc.ai[1] >= 8)
                {
                    Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y - npc.height), new Vector2(0, 10), ProjectileID.PinkLaser, npc.damage / 3, 1.5f);
                    npc.ai[1] = 0;
                    shootAttack = false;
                }
            }
            if (npc.Center.X < target.X && npc.velocity.X < 6)
            {
                npc.velocity.X += 0.2f;
            }
            else if (npc.velocity.X > -6)
            {
                npc.velocity.X -= 0.2f;
            }
            if (npc.Center.Y > target.Y - 200)
            {
                npc.velocity.Y -= 0.2f;
            }
            else if (npc.Center.Y < target.Y - 250) 
            {
                npc.velocity.Y += 0.2f; 
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Sky.Chance * 0.2f;
        }
    }
}
