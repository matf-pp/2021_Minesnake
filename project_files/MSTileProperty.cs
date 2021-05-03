using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSnake
{
	public enum MSTileProperty
	{
		MINE,
		SNAKE,
		FOOD,
		OBSTACLE,
		START,
		MINE_COUNT_1,
		MINE_COUNT_2,
		MINE_COUNT_3,
		MINE_COUNT_4,
		MINE_COUNT_5,
		MINE_COUNT_6,
		MINE_COUNT_7,
		MINE_COUNT_8
	};

	// Converts tile property to string.
	class TilePropertyToStringConverter
	{
		// Returns tile property represented as a string.
		public static string toString(MSTileProperty p)
		{
			switch (p)
			{
				case MSTileProperty.MINE:
					return "MINE";
					
				case MSTileProperty.SNAKE:
					return "SNAKE";
					
				case MSTileProperty.FOOD:
					return "FOOD";
					
				case MSTileProperty.OBSTACLE:
					return "OBSTACLE";
					
				case MSTileProperty.START:
					return "START";
				case MSTileProperty.MINE_COUNT_1:
					return "MINE_1";
					
				case MSTileProperty.MINE_COUNT_2:
					return "MINE_2";
					
				case MSTileProperty.MINE_COUNT_3:
					return "MINE_3";
					
				case MSTileProperty.MINE_COUNT_4:
					return "MINE_4";
					
				case MSTileProperty.MINE_COUNT_5:
					return "MINE_5";
					
				case MSTileProperty.MINE_COUNT_6:
					return "MINE_6";
					
				case MSTileProperty.MINE_COUNT_7:
					return "MINE_7";
					
				case MSTileProperty.MINE_COUNT_8:
					return "MINE_8";
					
				default:
					return "";
					
			}
		}
	}
}

