using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSnake
{
    public class MSGrid
    {
        private int height;
        private int width;
        private List<List<MSTile>> grid = new List<List<MSTile>>();

        public MSGrid()
        {
        }

        public MSGrid(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new MSException("SIZE_INSUFFICIENT");
            }

            height = x;
            width = y;

            for (int i = 0; i < x; i++)
            {
                List<MSTile> t = new List<MSTile>();

                for (int j = 0; j < y; j++)
                {
                    t.Add(new MSTile());
                }

                grid.Add(t);
            }
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }

        public List<List<MSTile>> getGrid()
        {
            return grid;
        }

        public void setTile(int x, int y, MSTile t)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y] = t;
        }

        public void setTile(int x, int y, MSTileProperty t)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y] = new MSTile(t);
        }

        public void setTile(int x, int y, List<MSTileProperty> ps)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            MSTile t = new MSTile();
            t.addProperties(ps);

            grid[x][y] = t;
        }

        public void setTiles(List<int> xs, List<int> ys, MSTileProperty p)
        {
            int xsize = xs.Count();
            int ysize = ys.Count();
            int l = xsize < ysize ? xsize : ysize;

            for (int i = 0; i < l; i++)
            {
                try
                {
                    setTile(xs[i], ys[i], p);
                }
                catch (MSException)
                {
                    throw new MSException("INDEX_OUT_OF_BOUNDS");
                }
            }
        }

        public void setTiles(List<int> xs, List<int> ys, List<MSTileProperty> ps)
        {
            int xsize = xs.Count();
            int ysize = ys.Count();
            int l = xsize < ysize ? xsize : ysize;

            for (int i = 0; i < l; i++)
            {
                setTile(xs[i], ys[i], ps);
            }
        }

        public MSTile getTile(int x, int y)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            return grid[x][y];
        }

        public void addProperty(int x, int y, MSTileProperty p)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y].addProperty(p);
        }

        public void addProperties(int x, int y, List<MSTileProperty> ps)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y].addProperties(ps);
        }

        public void addProperties(List<int> xs, List<int> ys, List<MSTileProperty> ps)
        {
            int xsize = xs.Count();
            int ysize = ys.Count();
            int l = xsize < ysize ? xsize : ysize;

            for (int i = 0; i < l; i++)
            {
                setTile(xs[i], ys[i], ps);
            }
        }

        public List<MSTileProperty> getProperties(int x, int y)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            return grid[x][y].getProperties();
        }

        public void removeProperty(int x, int y, MSTileProperty p)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y].removeProperty(p);
        }

        public bool isOf(int x, int y, MSTileProperty p)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            return grid[x][y].isOf(p);
        }

        public void decreaseMineCount(int x, int y)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            grid[x][y].decreaseMineCount();
        }

        public List<MSTile> getNeighbourhood(int x, int y)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            List<MSTile> t = new List<MSTile>();

            if (isIncluded(x - 1, y - 1))
            {
                t.Add(getTile(x - 1, y - 1));
            }
            if (isIncluded(x - 1, y))
            {
                t.Add(getTile(x - 1, y));
            }
            if (isIncluded(x - 1, y + 1))
            {
                t.Add(getTile(x - 1, y + 1));
            }
            if (isIncluded(x, y - 1))
            {
                t.Add(getTile(x, y - 1));
            }
            if (isIncluded(x, y + 1))
            {
                t.Add(getTile(x, y + 1));
            }
            if (isIncluded(x + 1, y - 1))
            {
                t.Add(getTile(x + 1, y - 1));
            }
            if (isIncluded(x + 1, y))
            {
                t.Add(getTile(x + 1, y));
            }
            if (isIncluded(x + 1, y + 1))
            {
                t.Add(getTile(x + 1, y + 1));
            }

            return t;
        }

        public List<Tuple<int, int>> getPassableNeighbourhood(int x, int y)
        {
            if (!isIncluded(x, y))
            {
                throw new MSException("INDEX_OUT_OF_BOUNDS");
            }

            List<Tuple<int, int>> t = new List<Tuple<int, int>>();

            if (isIncluded(x, y - 1) && !isOf(x, y - 1, MSTileProperty.OBSTACLE))
            {
                t.Add(new Tuple<int, int>(x + 0, y - 1));
            }
            if (isIncluded(x, y + 1) && !isOf(x, y + 1, MSTileProperty.OBSTACLE))
            {
                t.Add(new Tuple<int, int>(x + 0, y + 1));
            }
            if (isIncluded(x - 1, y) && !isOf(x - 1, y, MSTileProperty.OBSTACLE))
            {
                t.Add(new Tuple<int, int>(x - 1, y + 0));
            }
            if (isIncluded(x + 1, y) && !isOf(x + 1, y, MSTileProperty.OBSTACLE))
            {
                t.Add(new Tuple<int, int>(x + 1, y + 0));
            }

            return t;
        }

        public bool isIncluded(int x, int y)
        {
            return x >= 0 && y >= 0 && x < height && y < width;
        }

        public Tuple<int, int> getStart()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (isOf(i, j, MSTileProperty.START))
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            throw new MSException("NO_STARTING_TILE");
        }

        public void spawnFood()
        {
            Random r = new Random();

            while (true)
            {
                int xc = r.Next() % height;
                int yc = r.Next() % width;

                if (!isOf(xc, yc, MSTileProperty.OBSTACLE) && !isOf(xc, yc, MSTileProperty.START) && !isOf(xc, yc, MSTileProperty.MINE) && !isOf(xc, yc, MSTileProperty.SNAKE))
                {
                    addProperty(xc, yc, MSTileProperty.FOOD);
                    break;
                }
            }
        }
    }

}
