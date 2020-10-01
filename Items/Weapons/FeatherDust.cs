using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SpaceModjam.Items.Weapons
{
    class FeatherDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.frame = new Rectangle(0, 0, 20, 8);
            dust.scale = Main.rand.Next(7, 15) / 10;
        }
    }
}
