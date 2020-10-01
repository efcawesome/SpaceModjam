using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SpaceModjam.Tiles
{
	public class CloudOre : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; 
			Main.tileValue[Type] = 410; 
			Main.tileShine2[Type] = true; 
			Main.tileShine[Type] = 975; 
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cloud Ore");
			AddMapEntry(new Color(152, 171, 198), name);

			dustType = 84;
			drop = ItemType<Items.Cloud_Ore>();
			soundType = 21;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 55;
		}
	}
}
