using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class GelPick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Pick"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Bouncy");
		}

		public override void SetDefaults() 
		{
			item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.pick = 60;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 34);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}