using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunGen
{
	class Tile
	{
		private Coord coord;
		public Coord GetCoord() => coord;
		public void SetCoord(Coord c) { coord = c ?? throw new ArgumentNullException(nameof(c)); }

	}
}
