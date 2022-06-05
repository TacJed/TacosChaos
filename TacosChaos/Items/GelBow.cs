using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class GelBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.knockBack = 31;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 6.25f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 21);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(6,0);
			return offset;
        }
    }
}