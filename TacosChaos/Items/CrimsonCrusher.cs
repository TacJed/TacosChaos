using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class CrimsonCrusher : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Crimson Crusher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Voices...");
		}

		public override void SetDefaults() 
		{
			item.damage = 127;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 80;
			item.useAnimation = 80;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.Meteor1;
			item.shootSpeed = 3f;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.OnFire, 999999);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Blood, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 50);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}