using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Made Of Slimes.");
		}

		public override void SetDefaults() 
		{
			item.damage = 4;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 1;
			item.knockBack = 23;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}