using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam
{
	public class SpaceModjam : Mod
	{
		internal static SpaceModjam instance;
		
		public static string PlaceholderTexture = "SpaceModjam/PLACEHOLDER";
		
		public SpaceModjam()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
				AutoloadBackgrounds = true
			};
		}
		
		public override void Load()
		{
			instance = this;
		}
		
		public override void Unload()
		{
			instance = null;
		}
		
		public override void PostSetupContent()
		{
			// Boss Checklist Compatibility
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			if (bossChecklist != null)
			{
				// When we have an actual boss, we'll make it.
			}
		}
	}
}