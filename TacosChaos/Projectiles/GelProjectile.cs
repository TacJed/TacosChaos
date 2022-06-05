using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TacosChaos.Projectiles
{
	public class GelProjectile : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gel Projectile"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.magic = true;
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 99999999;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = false;
			projectile.tileCollide = true;
		}

        public override void AI()
        {
			int dust = Dust.NewDust(projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.5f;
			Main.dust[dust].scale = (float)Main.rand.Next(160, 230) * 0.013f;
			Main.dust[dust].noGravity = true;
        }
    }
}