using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SpaceModjam.Items.Materials;

namespace SpaceModjam.Tiles
{
	public class CloudOreTile : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true; 
			Main.tileShine2[Type] = true; 
			Main.tileValue[Type] = 410; 
			Main.tileShine[Type] = 975; 

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cloud Ore");
			AddMapEntry(new Color(152, 171, 198), name);

			dustType = 84;
			drop = ModContent.ItemType<CloudOre>();
			soundType = SoundID.Tink;
			soundStyle = 1;
			mineResist = 2f;
			minPick = 55;
		}
	}
}
