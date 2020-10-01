using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SpaceModjam.Tiles;

namespace SpaceModjam.Items.Materials
{
	public class CloudOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cloud Ore");
		}

		public override void SetDefaults()
		{
			item.useTurn = true;
			item.autoReuse = true;
			item.consumable = true;
			item.maxStack = 999;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 15;
			item.createTile = ModContent.TileType<CloudOreTile>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice();
		}
	}
}
