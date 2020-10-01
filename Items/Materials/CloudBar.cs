using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items.Materials
{
	public class CloudBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cloud Bar");
			Tooltip.SetDefault("A fragment of the clouds forged into a bar");
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
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice();
		}

		public override void AddRecipes() 
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CloudOre>(), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
