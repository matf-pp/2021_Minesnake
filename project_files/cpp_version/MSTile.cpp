#ifndef __TILE__
#define __TILE__

#include <vector>
#include <algorithm>
#include <sstream>
#include <string>
#include "MSTileProperty.cpp"

// Represents a tile with its properties.
class MSTile {
private:
	std::vector<MSTileProperty> properties;
	int propertyCount = 0;

public:
	// Creates an empty tile.
	MSTile() {
	};

	// Creates a tile with a given property.
	MSTile(MSTileProperty p) {
		addProperty(p);
	}

	// Creates tile with given properties.
	MSTile(const std::vector<MSTileProperty>& ps) {
		addProperties(ps);
	}

	// Adds a property to a tile if it does not already contain one of the same kind; otherwise does nothing.
	void addProperty(MSTileProperty p) {
		for (auto x : properties) {
			if (x == p) {
				return;
			}
		}

		properties.push_back(p);
		propertyCount ++;
	}

	// Adds all properties from the given vector to the tile ignoring ones that are already contained.
	void addProperties(const std::vector<MSTileProperty>& ps) {
		for (auto p : ps) {
			addProperty(p);
		}
	}

	// Returns vector containing all the tile properties.
	auto getProperties() {
		return properties;
	}

	// Returns number of properties a tile has.
	int getPropertyCount() {
		return propertyCount;
	}

	// Removes given property from tile's properties if it exists; otherwise does nothing.
	void removeProperty(MSTileProperty p) {
		auto e1 = properties.end();
		auto e2 = std::remove(properties.begin(), e1, p);

		properties.erase(e2, e1);

		if (e1 != e2) {
			propertyCount --;
		}
	}

	// Checks whether the tile contains given property.
	bool isOf(MSTileProperty p) {
		for (auto x : properties) {
			if (x == p) {
				return true;
			}
		}

		return false;
	}

	// Decreases mine count property by one if it exists; otherwise does nothing.
	void decreaseMineCount() {
		if (isOf(MSTileProperty::MINE_COUNT_1)) {
			removeProperty(MSTileProperty::MINE_COUNT_1);
		} else if (isOf(MSTileProperty::MINE_COUNT_2)) {
			removeProperty(MSTileProperty::MINE_COUNT_2);
			addProperty(MSTileProperty::MINE_COUNT_1);
		} else if (isOf(MSTileProperty::MINE_COUNT_3)) {
			removeProperty(MSTileProperty::MINE_COUNT_3);
			addProperty(MSTileProperty::MINE_COUNT_2);
		} else if (isOf(MSTileProperty::MINE_COUNT_4)) {
			removeProperty(MSTileProperty::MINE_COUNT_4);
			addProperty(MSTileProperty::MINE_COUNT_3);
		} else if (isOf(MSTileProperty::MINE_COUNT_5)) {
			removeProperty(MSTileProperty::MINE_COUNT_5);
			addProperty(MSTileProperty::MINE_COUNT_4);
		} else if (isOf(MSTileProperty::MINE_COUNT_6)) {
			removeProperty(MSTileProperty::MINE_COUNT_6);
			addProperty(MSTileProperty::MINE_COUNT_5);
		} else if (isOf(MSTileProperty::MINE_COUNT_7)) {
			removeProperty(MSTileProperty::MINE_COUNT_7);
			addProperty(MSTileProperty::MINE_COUNT_6);
		} else if (isOf(MSTileProperty::MINE_COUNT_8)) {
			removeProperty(MSTileProperty::MINE_COUNT_8);
			addProperty(MSTileProperty::MINE_COUNT_7);
		}
	}

	// Returns stringstream repesenting tile's properties.
	std::stringstream toStringStream() {
		std::stringstream s;

		for (int i = 0; i < propertyCount - 1; i ++) {
			s << TilePropertyToStringConverter::toString(properties[i]) << ", ";
		}

		if (propertyCount > 0) {
			s << TilePropertyToStringConverter::toString(properties[propertyCount - 1]);
		}

		return s;
	}

	// Returns string repesenting tile's properties.
	std::string toString() {
		return toStringStream().str();
	}
};

#endif
