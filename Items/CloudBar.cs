using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items
{
	public class CloudBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Cloud Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("a fragment of the clouds forged into a bar");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 300;
			item.rare = ItemRarityID.Green;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CloudOre", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
