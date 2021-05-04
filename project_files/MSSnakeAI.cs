using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSnake
{
    public class MSSnakeAI
    {
        public void setSnake(MSSnake s)
        {

        }

        public void setGrid(MSGrid g)
        {

        }

        public List<MSDirection> getDirections(MSGrid _grid, Tuple<int, int> scoords)
        {
            List<List<MSTile>> grid = _grid.getGrid();
            int h = _grid.getHeight();
            int w = _grid.getWidth();
            List<List<int>> matrix = new List<List<int>>();
            List<List<int>> matrix_visited = new List<List<int>>();
            List<List<int>> matrix_distances = new List<List<int>>();
            int i, j;

            for (i = 0; i < h; i++)
            {
                List<int> t1 = new List<int>();
                List<int> t2 = new List<int>();
                List<int> t3 = new List<int>();
                for (j = 0; j < w; j++)
                {
                    t1.Add(0);
                    t2.Add(0);
                    t3.Add(0);

                }
                matrix.Add(t1);
                matrix_visited.Add(t2);
                matrix_distances.Add(t3);
            }

            int xstart = scoords.Item1, ystart = scoords.Item2, xstop = 0, ystop = 0;
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    matrix_visited[i][j] = 0;
                    matrix_distances[i][j] = 0;
                    if (!grid[i][j].isOf(MSTileProperty.OBSTACLE))
                        matrix[i][j] = 0;
                    else
                        matrix[i][j] = 1;

                    if (grid[i][j].isOf(MSTileProperty.FOOD))
                    {
                        xstop = i;
                        ystop = j;
                    }

                }

            }
            Queue<Tuple<int, int>> Q = new Queue<Tuple<int, int>>();
            List<List<Tuple<int, int>>> rekonstrukcija = new List<List<Tuple<int, int>>>();
            Q.Enqueue(new Tuple<int, int>(xstart, ystart));

            for (i = 0; i < h; i++)
            {
                List<Tuple<int, int>> t = new List<Tuple<int, int>>();
                for (j = 0; j < w; j++)
                {
                    t.Add(new Tuple<int, int>(0, 0));
                }
                rekonstrukcija.Add(t);
            }

            while (Q.Count() != 0)
            {
                Tuple<int, int> current = Q.Dequeue();
                i = current.Item1;
                j = current.Item2;
                if (matrix_visited[i][j] != 0) continue;
                matrix_visited[i][j] = 1;

                if (i == xstop && j == ystop) { break; }
                if (i + 1 <= h - 1 && matrix_visited[i + 1][j] == 0 && matrix[i + 1][j] != 1 && !grid[i + 1][j].isOf(MSTileProperty.SNAKE) && !grid[i + 1][j].isOf(MSTileProperty.OBSTACLE))
                {
                    Q.Enqueue(new Tuple<int, int>(i + 1, j));
                    matrix_distances[i + 1][j] = matrix_distances[i][j] + 1;
                    rekonstrukcija[i + 1][j] = new Tuple<int, int>(i, j);
                }
                if (j + 1 <= w - 1 && matrix_visited[i][j + 1] == 0 && matrix[i][j + 1] != 1 && !grid[i][j + 1].isOf(MSTileProperty.SNAKE) && !grid[i][j + 1].isOf(MSTileProperty.OBSTACLE))
                {
                    Q.Enqueue(new Tuple<int, int>(i, j + 1));
                    matrix_distances[i][j + 1] = matrix_distances[i][j] + 1;
                    rekonstrukcija[i][j + 1] = new Tuple<int, int>(i, j);
                }
                if (i - 1 >= 0 && matrix_visited[i - 1][j] == 0 && matrix[i - 1][j] != 1 && !grid[i - 1][j].isOf(MSTileProperty.SNAKE) && !grid[i - 1][j].isOf(MSTileProperty.OBSTACLE))
                {
                    Q.Enqueue(new Tuple<int, int>(i - 1, j));
                    matrix_distances[i - 1][j] = matrix_distances[i - 1][j] + 1;
                    rekonstrukcija[i - 1][j] = new Tuple<int, int>(i, j);
                }
                if (j - 1 >= 0 && matrix_visited[i][j - 1] == 0 && matrix[i][j - 1] != 1 && !grid[i][j - 1].isOf(MSTileProperty.SNAKE) && !grid[i][j - 1].isOf(MSTileProperty.OBSTACLE))
                {
                    Q.Enqueue(new Tuple<int, int>(i, j - 1));
                    matrix_distances[i][j - 1] = matrix_distances[i][j] + 1;
                    rekonstrukcija[i][j - 1] = new Tuple<int, int>(i, j);
                }

            }
            i = xstop;
            j = ystop;
            List<MSDirection> directions = new List<MSDirection>();
            List<Tuple<int, int>> temporary = new List<Tuple<int, int>>();
            // temporary.Add(new Tuple<int, int>(i, j));
            while (!(i == xstart && j == ystart))
            {
                temporary.Add(new Tuple<int, int>(i, j));
                Tuple<int, int> current = rekonstrukcija[i][j];
                i = current.Item1; 
                j = current.Item2;
            }
            temporary.Add(new Tuple<int, int>(xstart, ystart));
            for (i = 0; i < temporary.Count - 1; i++)
            {
                if (temporary[i].Item1 == temporary[i + 1].Item1 + 1)
                    directions.Add(MSDirection.DOWN);
                if (temporary[i].Item1 == temporary[i + 1].Item1 - 1)
                    directions.Add(MSDirection.UP);
                if (temporary[i].Item2 == temporary[i + 1].Item2 + 1)
                    directions.Add(MSDirection.RIGHT);
                if (temporary[i].Item2 == temporary[i + 1].Item2 - 1)
                    directions.Add(MSDirection.LEFT);
            }
            return directions;
        }
    }
}
