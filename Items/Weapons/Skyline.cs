using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace SpaceModjam.Items.Weapons
{
    class Skyline : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Light as a feather.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.damage = 20;
            item.knockBack = 2f;
            item.autoReuse = true;
            item.useTurn = true;
            item.melee = true;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<SkylineProj>();
            item.shootSpeed = 10.75f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Feather, 15);
            recipe.AddIngredient(ItemID.Cloud, 25);
            recipe.AddIngredient(mod.ItemType("CloudBar"), 10); //Didnt have the latest github so using non-reference version
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
