using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace TacosChaos.Items
{
	public class GelStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Wait... Is It Alive?.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 22;
			item.mana = 1;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 10;
			item.value = 1500;
			item.rare = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GelProjectile");
			item.shootSpeed = 8f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			return true;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ItemID.Sapphire, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}