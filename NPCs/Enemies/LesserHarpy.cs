using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.NPCs.Enemies {
    public class LesserHarpy : ModNPC {
        float x = 0;
        float y = 0;
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Leser Harpy");
        }
        public override void SetDefaults() {
            npc.noGravity = true;
            npc.noTileCollide = false;
            npc.netAlways = true;
            npc.width = 208;
            npc.height = 152;
            npc.damage = 20;
            npc.lifeMax = 250;
            npc.defense = 15;
            npc.aiStyle = -1;
            aiType = -1;
            npc.knockBackResist = 0.5f;
            npc.npcSlots = 1f;
            npc.scale = 0.3f;
        }

        public override void AI() {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;

            // apply force every 15 updates
            // aim for a moving circle around player
            // if far away apply force every 5 updates
            npc.ai[0]++;
            x += 0.2f;
            y += 0.2f;
            y += 0.2f;
            float xRangeToPlayer = Main.player[npc.target].Center.X - npc.Center.X;
            float yRangeToPlayer = Main.player[npc.target].Center.Y - npc.Center.Y - 300f;
            float rangeToPlayer = (float)Math.Sqrt((double)(xRangeToPlayer * xRangeToPlayer + yRangeToPlayer * yRangeToPlayer));
            if (npc.ai[0] % 10 == 0) {
                move(0.25f);
            }
            if (npc.ai[0] % 5 == 0 && rangeToPlayer > 400) {
                move(0.10f);
            }



            if (npc.ai[0] % 300 == 0) {
                Vector2 angle = target - npc.Center;
                angle.Normalize();
                Projectile.NewProjectile(new Vector2(npc.Center.X, npc.Center.Y), angle * 3, ProjectileID.HarpyFeather, npc.damage, 1f);
            }

            void move(float speed) {
                Vector2 angle = new Vector2(target.X + (float)Math.Sin(x), target.Y + (float)Math.Sin(y)) - npc.Center;
                angle.Normalize();
                npc.velocity += angle * speed;
                npc.velocity.X = Math.Min(Math.Max(npc.velocity.X, -2), 2);
                npc.velocity.Y = Math.Min(Math.Max(npc.velocity.Y, -2), 2);
            }
        }
        public override void FindFrame(int frameHeight) {
            if (npc.spriteDirection != npc.direction) {
                npc.rotation = 0;
            }
            npc.spriteDirection = npc.direction;
            npc.rotation += (npc.direction * (float)Math.PI / 180) / 2;
            npc.rotation = Math.Min(Math.Max(npc.rotation, -30 * (float)Math.PI / 180), 30 * (float)Math.PI / 180);

            // Will add this in later once has animation frames
            // npc.frame.Width = 40;
            // if (((int)Main.time / 10) % 2 == 0) {
            //     npc.frame.X = 40;
            // } else {
            //     npc.frame.X = 0;
            // }
            // npc.frame.Y = 0;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
            return SpawnCondition.Sky.Chance * 0.2f;
        }
    }
}
