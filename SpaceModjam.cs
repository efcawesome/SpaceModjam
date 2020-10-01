using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpaceModjam
{
	public class SpaceModjam : Mod
	{
		internal static SpaceModjam instance;
		
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
	}
}