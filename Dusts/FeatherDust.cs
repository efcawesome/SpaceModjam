using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SpaceModjam.Dusts
{
    public class FeatherDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.frame = new Rectangle(0, 0, 20, 8);
            dust.scale = Main.rand.Next(7, 15) / 10;
        }
    }
}
