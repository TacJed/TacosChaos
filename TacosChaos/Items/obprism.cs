using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class obprism : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Obama Prism"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Skill Issue Solver");
		}

		public override void SetDefaults() 
		{
			item.damage = 99999;
			item.ranged = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 1000;
			item.value = 100000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.StarWrath;
			item.shootSpeed = 12f;
			item.noMelee = true;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.Electrified, 99999999);
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
			recipe.AddIngredient(ItemID.PlatinumCoin, 999);
			recipe.AddTile(TileID.Chairs);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}