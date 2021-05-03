using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSnake
{
    public class MSSnake
    {
        private int length;
        private List<MSDirection> directions = new List<MSDirection>();
        private MSGrid grid = new MSGrid();
        private bool gridDefined = false;
        private List<Tuple<int, int>> places = new List<Tuple<int, int>>();

        public MSSnake()
        {
        }

        public MSSnake(int x)
        {
            setLength(x);
        }

        public void setLength(int x)
        {
            if (x <= 0 || (gridDefined && x >= grid.getHeight() * grid.getWidth()))
            {
                throw new MSException("SNAKE_SIZE_INVALID");
            }

            length = x;
        }

        public void setGrid(MSGrid g)
        {
            grid = g;
            gridDefined = true;
        }

        public void setDirections(List<MSDirection> ds)
        {
            directions = ds;
        }

        public Tuple<int, int> getHeadCoordinates()
        {
            if (places.Count() == 0)
            {
                throw new MSException("SNAKE_SIZE_INVALID");
            }

            return places[0];
        }

        public void move(int x)
        {
            if (x == 0 || directions.Count() == 0)
            {
                return;
            }

            if (places.Count() == 0)
            {
                Tuple<int, int> s = grid.getStart();

                places.Insert(0, s);
                grid.addProperty(s.Item1, s.Item2, MSTileProperty.SNAKE);
            }
            else
            {
                int i = directions.Count() - 1;
                MSDirection d = directions[i];
                directions.RemoveAt(i);
                Tuple<int, int> headCoords1 = places[0];
                int hcx = headCoords1.Item1;
                int hcy = headCoords1.Item2;

                switch (d)
                {
                    case MSDirection.DOWN:
                        if (!grid.isIncluded(hcx + 1, hcy) || grid.isOf(hcx + 1, hcy, MSTileProperty.OBSTACLE) || grid.isOf(hcx + 1, hcy, MSTileProperty.SNAKE))
                        {
                            throw new MSException("SNAKE_IN_INVALID_POSITION");
                        }

                        if (grid.isOf(hcx + 1, hcy, MSTileProperty.MINE))
                        {
                            throw new MSException("SNAKE_ON_A_MINE");
                        }

                        if (places.Count() == length)
                        {
                            int j = places.Count() - 1;
                            Tuple<int, int> endCoords = places[j];
                            places.RemoveAt(j);
                            grid.removeProperty(endCoords.Item1, endCoords.Item2, MSTileProperty.SNAKE);
                        }

                        places.Insert(0, new Tuple<int, int>(hcx + 1, hcy));
                        grid.addProperty(hcx + 1, hcy, MSTileProperty.SNAKE);
                        break;
                    case MSDirection.UP:
                        if (!grid.isIncluded(hcx - 1, hcy) || grid.isOf(hcx - 1, hcy, MSTileProperty.OBSTACLE) || grid.isOf(hcx - 1, hcy, MSTileProperty.SNAKE))
                        {
                            throw new MSException("SNAKE_IN_INVALID_POSITION");
                        }

                        if (grid.isOf(hcx - 1, hcy, MSTileProperty.MINE))
                        {
                            throw new MSException("SNAKE_ON_A_MINE");
                        }

                        if (places.Count() == length)
                        {
                            int j = places.Count() - 1;
                            Tuple<int, int> endCoords = places[j];
                            places.RemoveAt(j);
                            grid.removeProperty(endCoords.Item1, endCoords.Item2, MSTileProperty.SNAKE);
                        }

                        places.Insert(0, new Tuple<int, int>(hcx - 1, hcy));
                        grid.addProperty(hcx - 1, hcy, MSTileProperty.SNAKE);
                        break;
                    case MSDirection.LEFT:
                        if (!grid.isIncluded(hcx, hcy - 1) || grid.isOf(hcx, hcy - 1, MSTileProperty.OBSTACLE) || grid.isOf(hcx, hcy - 1, MSTileProperty.SNAKE))
                        {
                            throw new MSException("SNAKE_IN_INVALID_POSITION");
                        }

                        if (grid.isOf(hcx, hcy - 1, MSTileProperty.MINE))
                        {
                            throw new MSException("SNAKE_ON_A_MINE");
                        }

                        if (places.Count() == length)
                        {
                            int j = places.Count() - 1;
                            Tuple<int, int> endCoords = places[j];
                            places.RemoveAt(j);
                            grid.removeProperty(endCoords.Item1, endCoords.Item2, MSTileProperty.SNAKE);
                        }

                        places.Insert(0, new Tuple<int, int>(hcx, hcy - 1));
                        grid.addProperty(hcx, hcy - 1, MSTileProperty.SNAKE);
                        break;
                    case MSDirection.RIGHT:
                        if (!grid.isIncluded(hcx, hcy + 1) || grid.isOf(hcx, hcy + 1, MSTileProperty.OBSTACLE) || grid.isOf(hcx, hcy + 1, MSTileProperty.SNAKE))
                        {
                            throw new MSException("SNAKE_IN_INVALID_POSITION");
                        }

                        if (grid.isOf(hcx, hcy + 1, MSTileProperty.MINE))
                        {
                            throw new MSException("SNAKE_ON_A_MINE");
                        }

                        if (places.Count() == length)
                        {
                            int j = places.Count() - 1;
                            Tuple<int, int> endCoords = places[j];
                            places.RemoveAt(j);
                            grid.removeProperty(endCoords.Item1, endCoords.Item2, MSTileProperty.SNAKE);
                        }

                        places.Insert(0, new Tuple<int, int>(hcx, hcy + 1));
                        grid.addProperty(hcx, hcy + 1, MSTileProperty.SNAKE);
                        break;
                    default:
                        throw new MSException("HOW_DID_WE_GET_HERE");
                }
            }

            Tuple<int, int> headCoords = places[0];

            if (grid.isOf(headCoords.Item1, headCoords.Item2, MSTileProperty.FOOD))
            {
                throw new MSException("SNAKE_ON_FOOD");
            }

            move(x - 1);
        }

        public void reset()
        {
            int n = places.Count();

            for (int i = 0; i < n; i++)
            {
                Tuple<int, int> p = places[0];
                places.RemoveAt(0);

                grid.removeProperty(p.Item1, p.Item2, MSTileProperty.SNAKE);
            }
        }
    }
}
