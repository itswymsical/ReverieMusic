using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ReverieMusic
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class ReverieMusic : Mod
    {
        public const string Abbreviation = "ReverieMusic";

        public const string AbbreviationPrefix = Abbreviation + ":";

        public static ReverieMusic Instance => ModContent.GetInstance<ReverieMusic>();

    }
}
