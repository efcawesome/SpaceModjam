using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items.Materials
{
	public class PurpleSludge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Sludge");
		}
		
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.width = 20;
			item.height = 20;
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(); // TODO - Add a value
		}
	}
}