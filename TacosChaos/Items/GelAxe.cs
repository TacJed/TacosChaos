using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class GelAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.damage = 4;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 22;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.axe = 10;
			item.hammer = 45;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 15);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}