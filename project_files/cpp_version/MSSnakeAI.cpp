#ifndef __SNAKEAI__
#define __SNAKEAI__

#include <vector>
#include "MSSnake.cpp"
#include "MSGrid.cpp"
#include "MSDirection.cpp"

// A class containing methods for navigating snake through grid (finding a path for snake movement).
class MSSnakeAI {
private:

public:
	void setSnake(MSSnake& s) {

	}

	void setGrid(MSGrid& g) {

	}

	std::vector<MSDirection> getDirections() {
		return std::vector<MSDirection> {DOWN, DOWN, RIGHT, RIGHT, RIGHT, DOWN, DOWN, LEFT, LEFT, DOWN, LEFT, DOWN, RIGHT, RIGHT,
			DOWN, DOWN, RIGHT, RIGHT, DOWN, DOWN, LEFT, LEFT, DOWN, LEFT, DOWN, RIGHT, RIGHT}; // ONLY FOR DEMONSTRATIVE PURPOSES
	}
};

#endif
