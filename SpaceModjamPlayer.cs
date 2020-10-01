using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam
{
	public class SpaceModjamPlayer : ModPlayer
	{
		// Accessories
		public bool doubleJumpSludge; // Sludge in a Bottle
		
		public override void ResetEffects()
		{
			doubleJumpSludge = false;
		}
	}
}