using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.NPCs.Enemies {
    public class SpaceSlime : ModNPC {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Space Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
        }
        public override void SetDefaults() {
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
            npc.width = 32;
            npc.height = 22;
            npc.damage = 20;
            npc.lifeMax = 250;
            npc.defense = 15;
            npc.aiStyle = 1;
            aiType = 1;
            npc.knockBackResist = 0.5f;
            npc.npcSlots = 1f;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = Item.sellPrice();
            animationType = 8;
            animationType = NPCID.BlueSlime;
        }

        public override void AI() {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;
            if (npc.Center.Y > target.Y + 20) {
                npc.velocity.Y -= 1f;
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
            return SpawnCondition.Sky.Chance * 0.2f;
        }
    }
}
