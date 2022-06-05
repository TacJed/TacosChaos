using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class FlamingGelSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Flaming Gel Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Mmmmmmmm Tasty.");
		}

		public override void SetDefaults() 
		{
			item.damage = 34;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 5000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.Flamelash;
			item.shootSpeed = 8f;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.OnFire, 999999);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 33);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}