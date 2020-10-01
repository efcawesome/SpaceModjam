using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items.Accessories
{
	public class SludgeinaBottle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sludge in a Bottle");
			Tooltip.SetDefault("");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 20;
			item.height = 20;
			item.waistSlot = 1;
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice();
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<SpaceModjamPlayer>().doubleJumpSludge = true;
			player.jumpSpeedBoost += 1.5f;
			player.doubleJumpCloud = true;
			player.slowFall = true;
		}
	}
}