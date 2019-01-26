using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunGen
{
	class Coord
	{
		private int x, y;
		public int GetX() { return x; }
		public void SetX(int _x) { x = _x; }
		public int GetY() { return y; }
		public void SetY(int _y) { y = _y; }

		public Coord(int _x, int _y) { x = _x; y = _y; }

		public static Coord operator +(Coord a, Coord b) { return new Coord(a.GetX() + b.GetX(), a.GetY() + b.GetY()); }
		public static Coord operator -(Coord a, Coord b) { return new Coord(a.GetX() - b.GetX(), a.GetY() - b.GetY()); }
	}
}