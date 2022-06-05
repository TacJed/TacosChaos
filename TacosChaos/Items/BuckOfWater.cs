using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class BuckOfWater : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Briming Bucket Of Water"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Its Moves By Itself?");
		}

		public override void SetDefaults() 
		{
			item.damage = 320;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 15000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.Typhoon;
			item.shootSpeed = 12f;
			item.noMelee = true;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.Suffocation, 1000);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.BlueTorch, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBucket, 1);
			recipe.AddIngredient(ItemID.GoldBar, 60);
			recipe.AddIngredient(ItemID.Sapphire, 15);
			recipe.AddIngredient(ItemID.MetalSink, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}