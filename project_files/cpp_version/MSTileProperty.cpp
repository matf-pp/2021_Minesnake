#ifndef __TILEPROPERTY__
#define __TILEPROPERTY__

#include <string>

// Defines a single property of a tile.
enum MSTileProperty {
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
class TilePropertyToStringConverter {
public:
	// Returns tile property represented as a string.
	static std::string toString(MSTileProperty p) {
		switch (p) {
		case MINE:
			return "MINE";
			break;
		case SNAKE:
			return "SNAKE";
			break;
		case FOOD:
			return "FOOD";
			break;
		case OBSTACLE:
			return "OBSTACLE";
			break;
		case START:
			return "START";
		case MINE_COUNT_1:
			return "MINE_1";
			break;
		case MINE_COUNT_2:
			return "MINE_2";
			break;
		case MINE_COUNT_3:
			return "MINE_3";
			break;
		case MINE_COUNT_4:
			return "MINE_4";
			break;
		case MINE_COUNT_5:
			return "MINE_5";
			break;
		case MINE_COUNT_6:
			return "MINE_6";
			break;
		case MINE_COUNT_7:
			return "MINE_7";
			break;
		case MINE_COUNT_8:
			return "MINE_8";
			break;
		default:
			return "";
			break;
		}
	}
};

#endif
