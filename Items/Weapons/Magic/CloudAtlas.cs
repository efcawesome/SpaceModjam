using Microsoft.Xna.Framework;
using SpaceModjam.Projectiles.Mage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam.Items.Weapons.Magic
{
    class CloudAtlas : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Crafted with paper as thin as air itself.");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.damage = 18;
            item.knockBack = 2f;
            item.autoReuse = true;
            item.useTurn = true;
            item.magic = true;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<CloudAtlasProj>();
            item.shootSpeed = 10.75f;
            item.mana = 13;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for(int i = 0; i < 3; i++)
            {
                Projectile proj = Projectile.NewProjectileDirect(position, new Vector2(speedX, speedY), type, damage, knockBack, Main.myPlayer);
                Vector2 rotatedVelocity = proj.velocity.RotatedBy(MathHelper.ToRadians(i == 0 ? 15 : (i == 1 ? 0 : -15)));
                proj.velocity = rotatedVelocity;
            }
            return false;
        }
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cloud, 25);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.Star, 5);
            recipe.AddIngredient(ModContent.ItemType<CloudBar>());
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
