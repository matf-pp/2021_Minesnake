using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSnake
{
    public class MSTile
    {
		private List<MSTileProperty> properties = new List<MSTileProperty>();
		private int propertyCount = 0;

		// Creates an empty tile.
		public MSTile()
		{
		}

		// Creates a tile with a given property.
		public MSTile(MSTileProperty p)
		{
			addProperty(p);
		}

		// Creates tile with given properties.
		public MSTile(List<MSTileProperty> ps) 
		{
			addProperties(ps);
		}

		// Adds a property to a tile if it does not already contain one of the same kind; otherwise does nothing.
		public void addProperty(MSTileProperty p)
		{
			foreach (MSTileProperty x in properties)
			{
				if (x == p)
				{
					return;
				}
			}

			properties.Add(p);
			propertyCount++;
		}

		// Adds all properties from the given vector to the tile ignoring ones that are already contained.
		public void addProperties(List<MSTileProperty> ps)
		{
			foreach (MSTileProperty p in ps)
			{
				addProperty(p);
			}
		}

		// Returns vector containing all the tile properties.
		public List<MSTileProperty> getProperties()
		{
			return properties;
		}

		// Returns number of properties a tile has.
		int getPropertyCount()
		{
			return propertyCount;
		}

		// Removes given property from tile's properties if it exists; otherwise does nothing.
		public void removeProperty(MSTileProperty p)
		{
			int ind = properties.RemoveAll(item => item == p);

			if (ind != 0)
			{
				propertyCount--;
			}
		}

		// Checks whether the tile contains given property.
		public bool isOf(MSTileProperty p)
		{
			foreach (MSTileProperty x in properties)
			{
				if (x == p)
				{
					return true;
				}
			}

			return false;
		}

		// Decreases mine count property by one if it exists; otherwise does nothing.
		public void decreaseMineCount()
		{
			if (isOf(MSTileProperty.MINE_COUNT_1))
			{
				removeProperty(MSTileProperty.MINE_COUNT_1);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_2))
			{
				removeProperty(MSTileProperty.MINE_COUNT_2);
				addProperty(MSTileProperty.MINE_COUNT_1);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_3))
			{
				removeProperty(MSTileProperty.MINE_COUNT_3);
				addProperty(MSTileProperty.MINE_COUNT_2);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_4))
			{
				removeProperty(MSTileProperty.MINE_COUNT_4);
				addProperty(MSTileProperty.MINE_COUNT_3);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_5))
			{
				removeProperty(MSTileProperty.MINE_COUNT_5);
				addProperty(MSTileProperty.MINE_COUNT_4);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_6))
			{
				removeProperty(MSTileProperty.MINE_COUNT_6);
				addProperty(MSTileProperty.MINE_COUNT_5);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_7))
			{
				removeProperty(MSTileProperty.MINE_COUNT_7);
				addProperty(MSTileProperty.MINE_COUNT_6);
			}
			else if (isOf(MSTileProperty.MINE_COUNT_8))
			{
				removeProperty(MSTileProperty.MINE_COUNT_8);
				addProperty(MSTileProperty.MINE_COUNT_7);
			}
		}


		// Returns string repesenting tile's properties.
		public string toString()
		{
			string s = "";

			for (int i = 0; i < propertyCount - 1; i++)
			{
				s += TilePropertyToStringConverter.toString(properties[i]);
				s += ", ";
			}

			if (propertyCount > 0)
			{
				s += TilePropertyToStringConverter.toString(properties[propertyCount - 1]);
			}

			return s;
		}
	}
}
