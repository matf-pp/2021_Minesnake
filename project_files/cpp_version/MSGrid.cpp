#ifndef __GRID__
#define __GRID__

#include <vector>
#include <sstream>
#include <string>
#include <utility>
#include <cstdlib>
#include <ctime>
#include "MSTile.cpp"
#include "MSTileProperty.cpp"
#include "MSException.cpp"

// Represents a tile grid with methods of managing it.
class MSGrid {
private:
	int height;
	int width;
	std::vector<std::vector<MSTile>> grid;

public:
	// Creates an empty grid.
	MSGrid() {
	}

	// Creates a grid with the given size and fills it with empty tiles if it is accurately given; otherwise throws SIZE_INSUFFICIENT exception.
	MSGrid(int x, int y) {
		if (x <= 0 || y <= 0) {
			throw MSException::SIZE_INSUFFICIENT;
		}

		height = x;
		width = y;
		
		for (int i = 0; i < x; i ++) {
			std::vector<MSTile> t;

			for (int j = 0; j < y; j ++) {
				t.push_back(MSTile());
			}

			grid.push_back(t);
		}
	}

	// Returns the height of the grid.
	int getHeight() {
		return height;
	}

	// Returns the width of the grid.
	int getWidth() {
		return width;
	}

	// Sets a tile on a given coordinates to given tile if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void setTile(int x, int y, MSTile t) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y] = t;
	}

	// Sets a tile on a given coordinates given property if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void setTile(int x, int y, MSTileProperty t) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y] = t;
	}

	// Sets a tile on a given coordinates given properties if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void setTile(int x, int y, const std::vector<MSTileProperty>& ps) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y] = MSTile(ps);
	}

	// Sets all the tiles on a given coordinates (pairing one-by-one with respect to the shorter vector) given property if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void setTiles(const std::vector<int>& xs, const std::vector<int>& ys, MSTileProperty p) {
		int xsize = xs.size();
		int ysize = ys.size();
		int l = xsize < ysize ? xsize : ysize;

		for (int i = 0; i < l; i ++) {
			try {
				setTile(xs[i], ys[i], p);
			} catch (MSException) {
				throw MSException::INDEX_OUT_OF_BOUNDS;
			}
		}
	}

	// Sets all the tiles on a given coordinates (pairing one-by-one with respect to the shorter vector) given properties if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void setTiles(const std::vector<int>& xs, const std::vector<int>& ys, const std::vector<MSTileProperty>& ps) {
		int xsize = xs.size();
		int ysize = ys.size();
		int l = xsize < ysize ? xsize : ysize;

		for (int i = 0; i < l; i ++) {
			setTile(xs[i], ys[i], ps);
		}
	}

	// Returns tile found on the given coordinates if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	MSTile getTile(int x, int y) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		return grid[x][y];
	}

	// Adds a property to a tile on given coordinates if it does not already contain one of the same kind; otherwise does nothing.
	// If coordinates are invalid, throws INDEX_OUT_OF_BOUNDS exception.
	void addProperty(int x, int y, MSTileProperty p) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y].addProperty(p);
	}

	// Adds all properties from the given vector to the tile on given coordinates ignoring ones that are already contained.
	// If coordinates are invalid, throws INDEX_OUT_OF_BOUNDS exception.
	void addProperties(int x, int y, const std::vector<MSTileProperty>& ps) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y].addProperties(ps);
	}

	// Adds all properties from the given vector to the tiles on given coordinates on given coordinates (pairing one-by-one with respect to the shorter vector) ignoring ones that are already contained.
	// If coordinates are invalid, throws INDEX_OUT_OF_BOUNDS exception.
	void addProperties(const std::vector<int>& xs, const std::vector<int>& ys, const std::vector<MSTileProperty>& ps) {
		int xsize = xs.size();
		int ysize = ys.size();
		int l = xsize < ysize ? xsize : ysize;

		for (int i = 0; i < l; i ++) {
			setTile(xs[i], ys[i], ps);
		}
	}

	// Returns vector containing all the properties of the tile on given coordinates if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	auto getProperties(int x, int y) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		return grid[x][y].getProperties();
	}

	// Removes given property from the tile on given coordinates properties if it exists; otherwise does nothing.
	// If coordinates are invalid, throws INDEX_OUT_OF_BOUNDS exception.
	void removeProperty(int x, int y, MSTileProperty p) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y].removeProperty(p);
	}

	// Checks whether the tile on given coordinates contains given property if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	bool isOf(int x, int y, MSTileProperty p) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		return grid[x][y].isOf(p);
	}

	// Decreases mine count of tile on give coordinates if those are correct; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	void decreaseMineCount(int x, int y) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		grid[x][y].decreaseMineCount();
	}

	// Returns vector consisting of tiles surrounding tile on a given coordinates if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	auto getNeighbourhood(int x, int y) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		std::vector<MSTile> t;

		if (isIncluded(x - 1, y - 1)) {
			t.push_back(getTile(x - 1, y - 1));
		}
		if (isIncluded(x - 1, y)) {
			t.push_back(getTile(x - 1, y));
		}
		if (isIncluded(x - 1, y + 1)) {
			t.push_back(getTile(x - 1, y + 1));
		}
		if (isIncluded(x, y - 1)) {
			t.push_back(getTile(x, y - 1));
		}
		if (isIncluded(x, y + 1)) {
			t.push_back(getTile(x, y + 1));
		}
		if (isIncluded(x + 1, y - 1)) {
			t.push_back(getTile(x + 1, y - 1));
		}
		if (isIncluded(x + 1, y)) {
			t.push_back(getTile(x + 1, y));
		}
		if (isIncluded(x + 1, y + 1)) {
			t.push_back(getTile(x + 1, y + 1));
		}

		return t;
	}

	// Returns vector consisting of pairs of coordinates surrounding tile on a given coordinates that can be accessed (ignoring placement of snake) if those are valid; otherwise throws INDEX_OUT_OF_BOUNDS exception.
	auto getPassableNeighbourhood(int x, int y) {
		if (!isIncluded(x, y)) {
			throw MSException::INDEX_OUT_OF_BOUNDS;
		}

		std::vector<std::pair<int, int>> t;

		if (isIncluded(x, y - 1) && !isOf(x, y - 1, MSTileProperty::OBSTACLE)) {
			t.push_back(std::make_pair<int, int>(x + 0, y - 1));
		}
		if (isIncluded(x, y + 1) && !isOf(x, y + 1, MSTileProperty::OBSTACLE)) {
			t.push_back(std::make_pair<int, int>(x + 0, y + 1));
		}
		if (isIncluded(x - 1, y) && !isOf(x - 1, y, MSTileProperty::OBSTACLE)) {
			t.push_back(std::make_pair<int, int>(x - 1, y + 0));
		}
		if (isIncluded(x + 1, y) && !isOf(x + 1, y, MSTileProperty::OBSTACLE)) {
			t.push_back(std::make_pair<int, int>(x + 1, y + 0));
		}
		
		return t;
	}

	// Checks whether the tile with the given coordinates is inside of a grid.
	bool isIncluded(int x, int y) {
		return x >= 0 && y >= 0 && x < height && y < width;
	}

	// Returns pair of coordinates of the starting tile; if multiple exist, returns coordinates for the first one.
	// If none exist, throws "No starting tile." excpetion.
	std::pair<int, int> getStart() {
		for (int i = 0; i < height; i ++) {
			for (int j = 0; j < width; j ++) {
				if (isOf(i, j, MSTileProperty::START)) {
					return std::make_pair(i, j);
				}
			}
		}

		throw MSException::NO_STARTING_TILE;
	}

	// Spawns food randomly on the board.
	void spawnFood() {
		while (true) {
			int xc = std::rand() % height;
			int yc = std::rand() % width;

			if (!isOf(xc, yc, MSTileProperty::OBSTACLE) && !isOf(xc, yc, MSTileProperty::START) && !isOf(xc, yc, MSTileProperty::MINE) && !isOf(xc, yc, MSTileProperty::SNAKE)) {
				addProperty(xc, yc, MSTileProperty::FOOD);
				break;
			}
		}
	}

	// Returns stringstream representing grid and containing each tile's properties.
	std::stringstream toStringStream() {
		std::stringstream s;

		for (auto r : grid) {
			for (auto t : r) {
				s << "[" << t.toString() << "]";
			}

			s << "\n";
		}

		return s;
	}

	// Returns string representing grid and containing each tile's properties.
	std::string toString() {
		return toStringStream().str();
	}
};

#endif
