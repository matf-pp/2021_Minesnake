#ifndef __SNAKE__
#define __SNAKE__

#include <vector>
#include <utility>
#include <list>
#include "MSDirection.cpp"
#include "MSGrid.cpp"
#include "MSException.cpp"

// Represents a snake with necessary methods.
class MSSnake {
private:
	int length;
	std::vector<MSDirection> directions;
	MSGrid* grid; // Working with references produces bugs for reasons developer is too stupid to understand, so pointers had to be used with this class.
	bool gridDefined = false;
	std::list<std::pair<int, int>> places;

public:
	// Creates an empty snake.
	MSSnake() {
	}

	// Creates snake of a given length.
	MSSnake(int x) {
		setLength(x);
	}

	// Defines snake's length if it is valid; otherwise throws SNAKE_SIZE_INVALID exception.
	// MSGrid has to be assigned before calling tis function; otherwise same exception will be thrown.
	void setLength(int x) {
		if (x <= 0 || (gridDefined && x >= grid -> getHeight() * grid -> getWidth())) {
			throw MSException::SNAKE_SIZE_INVALID;
		}

		length = x;
	}

	// Defines snake's grid.
	void setGrid(MSGrid* g) {
		grid = g;
		gridDefined = true;
	}

	// Defines snake's directions vector.
	// Note: snake will move taking directions end-to-front of this vector.
	void setDirections(const std::vector<MSDirection>& ds) {
		directions = ds;
	}

	// Returns coordinates of snake's head. If it does not exist, SNAKE_SIZE_INVALID exception is thrown.
	auto getHeadCoordinates() {
		if (places.size() == 0) {
			throw MSException::SNAKE_SIZE_INVALID;
		}

		return places.front();
	}

	// Moves a snake given number of steps, according to directions if any of those exist; otherwise does nothing.
	// If snake encounters an obstacle or itself, the SNAKE_IN_INVALID_POSITION exception is thrown. If snake encounters a mine, the SNAKE_ON_A_MINE exception is thrown.
	// If snake encounters food, the SNAKE_ON_FOOD exception is thrown.
	void move(int x) {
		if (x == 0 || directions.size() == 0) {
			return;
		}

		if (places.size() == 0) {
			auto s = grid -> getStart();

			places.push_front(s);
			grid -> addProperty(std::get<0>(s), std::get<1>(s), MSTileProperty::SNAKE);
		} else {
			MSDirection d = directions.back();
			directions.pop_back();
			auto headCoords = places.front();
			int hcx = std::get<0>(headCoords);
			int hcy = std::get<1>(headCoords);

			switch (d) {
			case MSDirection::DOWN:
				if (!grid -> isIncluded(hcx + 1, hcy) || grid -> isOf(hcx + 1, hcy, MSTileProperty::OBSTACLE) || grid -> isOf(hcx + 1, hcy, MSTileProperty::SNAKE)) {
					throw MSException::SNAKE_IN_INVALID_POSITION;
				}

				if (grid -> isOf(hcx + 1, hcy, MSTileProperty::MINE)) {
					throw MSException::SNAKE_ON_A_MINE;
				}

				if (places.size() == length) {
					auto endCoords = places.back();
					places.pop_back();
					grid -> removeProperty(std::get<0>(endCoords), std::get<1>(endCoords), MSTileProperty::SNAKE);
				}

				places.push_front(std::make_pair(hcx + 1, hcy));
				grid -> addProperty(hcx + 1, hcy, MSTileProperty::SNAKE);
				break;
			case MSDirection::UP:
				if (!grid -> isIncluded(hcx - 1, hcy) || grid -> isOf(hcx - 1, hcy, MSTileProperty::OBSTACLE) || grid -> isOf(hcx - 1, hcy, MSTileProperty::SNAKE)) {
					throw MSException::SNAKE_IN_INVALID_POSITION;
				}

				if (grid -> isOf(hcx - 1, hcy, MSTileProperty::MINE)) {
					throw MSException::SNAKE_ON_A_MINE;
				}

				if (places.size() == length) {
					auto endCoords = places.back();
					places.pop_back();
					grid -> removeProperty(std::get<0>(endCoords), std::get<1>(endCoords), MSTileProperty::SNAKE);
				}

				places.push_front(std::make_pair(hcx - 1, hcy));
				grid -> addProperty(hcx - 1, hcy, MSTileProperty::SNAKE);
				break;
			case MSDirection::LEFT:
				if (!grid -> isIncluded(hcx, hcy - 1) || grid -> isOf(hcx, hcy - 1, MSTileProperty::OBSTACLE) || grid -> isOf(hcx, hcy - 1, MSTileProperty::SNAKE)) {
					throw MSException::SNAKE_IN_INVALID_POSITION;
				}

				if (grid -> isOf(hcx, hcy - 1, MSTileProperty::MINE)) {
					throw MSException::SNAKE_ON_A_MINE;
				}

				if (places.size() == length) {
					auto endCoords = places.back();
					places.pop_back();
					grid -> removeProperty(std::get<0>(endCoords), std::get<1>(endCoords), MSTileProperty::SNAKE);
				}

				places.push_front(std::make_pair(hcx, hcy - 1));
				grid -> addProperty(hcx, hcy - 1, MSTileProperty::SNAKE);
				break;
			case MSDirection::RIGHT:
				if (!grid -> isIncluded(hcx, hcy + 1) || grid -> isOf(hcx, hcy + 1, MSTileProperty::OBSTACLE) || grid -> isOf(hcx, hcy + 1, MSTileProperty::SNAKE)) {
					throw MSException::SNAKE_IN_INVALID_POSITION;
				}

				if (grid -> isOf(hcx, hcy + 1, MSTileProperty::MINE)) {
					throw MSException::SNAKE_ON_A_MINE;
				}

				if (places.size() == length) {
					auto endCoords = places.back();
					places.pop_back();
					grid -> removeProperty(std::get<0>(endCoords), std::get<1>(endCoords), MSTileProperty::SNAKE);
				}

				places.push_front(std::make_pair(hcx, hcy + 1));
				grid -> addProperty(hcx, hcy + 1, MSTileProperty::SNAKE);
				break;
			default:
				throw MSException::HOW_DID_WE_GET_HERE;
				break;
			}
		}

		auto headCoords = places.front();

		if (grid -> isOf(std::get<0>(headCoords), std::get<1>(headCoords), MSTileProperty::FOOD)) {
			throw MSException::SNAKE_ON_FOOD;
		}

		move(x - 1);
	}

	// Resets the snake without tempering with its directions or grid.
	void reset() {
		int n = places.size();

		for (int i = 0; i < n; i ++) {
			auto p = places.front();
			places.pop_front();

			grid -> removeProperty(std::get<0>(p), std::get<1>(p), MSTileProperty::SNAKE);
		}
	}
};

#endif
