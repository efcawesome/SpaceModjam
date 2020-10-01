using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using SpaceModjam.Items.Materials;
using SpaceModjam.Projectiles.Melee;

namespace SpaceModjam.Items.Weapons.Melee
{
    public class Skyline : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Light as a feather.");
        }
		
        public override void SetDefaults()
        {
			item.noMelee = true;
            item.noUseGraphic = true;
			item.autoReuse = true;
            item.useTurn = true;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.damage = 20;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<SkylineProj>();
            item.shootSpeed = 10f;
			item.knockBack = 2f;
			item.value = Item.sellPrice();
        }
		
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Feather, 15);
            recipe.AddIngredient(ItemID.Cloud, 25);
            recipe.AddIngredient(ModContent.ItemType<CloudBar>(), 10); //Didnt have the latest github so using non-reference version
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
