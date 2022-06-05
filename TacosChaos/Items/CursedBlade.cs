using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TacosChaos.Items
{
	public class CursedBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Cursed Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Double Edged Sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 178;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 15000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.ShadowBeamFriendly;
			item.shoot = ProjectileID.ShadowBeamHostile;
			item.shootSpeed = 8f;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.Bleeding, 999999);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.PurpleCrystalShard, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowScale, 50);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ItemID.Amethyst, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}