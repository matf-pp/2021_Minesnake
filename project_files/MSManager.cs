using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSnake
{
    public class MSManager
    {
        private MSGrid grid = new MSGrid();
        private MSSnake snake = new MSSnake();
        private MSTimer timer = new MSTimer();
        private Action paint;
        private Action<MSException> errFunc;
        private MSSnakeAI ai = new MSSnakeAI();
        private PictureBox[] pbGrid = new PictureBox[169];
        private bool[] visitedGrid = new bool[169];
        private int xCritical;
        private int yCritical;
        private int minesLeft;
        private int points = 0;

        public MSManager()
        {
            paint = () => imagine();
            errFunc = e => bad(e);
        }

        private int countMines(int x, int y)
        {
            if (grid.isIncluded(x, y))
            {
                int count = 0;

                foreach (MSTile t in grid.getNeighbourhood(x, y))
                {
                    if (t.isOf(MSTileProperty.MINE))
                    {
                        count++;
                    }
                }

                return count;
            }

            return 0;
        }

        private void onRuntimeException(MSException e)
        {
            if (e.Message == "SNAKE_ON_A_MINE")
            {
                timer.stop();
                paint();
                Tuple<int, int> hc = snake.getHeadCoordinates();
                xCritical = hc.Item1;
                yCritical = hc.Item2;
                errFunc(e);
            }
            else if (e.Message == "SNAKE_IN_INVALID_POSITION")
            {
                snake.reset();
                snake.setDirections(ai.getDirections(grid, grid.getStart()));
                paint();
                timer.resume();
            }
            else if (e.Message == "SNAKE_ON_FOOD")
            {
                Tuple<int, int> hc;

                try
                {
                    hc = snake.getHeadCoordinates();
                    grid.removeProperty(hc.Item1, hc.Item2, MSTileProperty.FOOD);
                    grid.spawnFood();

                    points += 40;

                    snake.setDirections(ai.getDirections(grid, hc));
                    paint();
                    timer.resume();
                }
                catch (MSException exception)
                {
                    timer.stop();
                    errFunc(exception);
                }
            }
        }

        private void imagine()
        {
            int height = grid.getHeight();
            int width = grid.getWidth();

            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < height; x++)
                {
                    try
                    {
                        if (visitedGrid[width*x + y])
                        {
                            if (grid.isOf(x, y, MSTileProperty.SNAKE))
                            {
                                if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_1))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\1mineAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_2))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\2minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_3))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\3minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_4))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\4minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_5))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\5minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_6))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\6minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_7))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\7minesAndSnake.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_8))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\8minesAndSnake.png");
                                }
                                else
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\0minesAndSnake.png");
                                }
                            }
                            else if (grid.isOf(x, y, MSTileProperty.FOOD))
                            {
                                if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_1))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\1mineAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_2))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\2minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_3))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\3minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_4))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\4minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_5))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\5minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_6))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\6minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_7))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\7minesAndFood.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_8))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\8minesAndFood.png");
                                }
                                else
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\0minesAndFood.png");
                                }
                            }
                            else if (grid.isOf(x, y, MSTileProperty.START))
                            {
                                if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_1))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\1mineAndStart.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_2))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\2minesAndStart.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_3))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\3minesAndStart.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_4))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\4minesAndStart.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_5))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\5minesAndStart.png");
                                }
                                else
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\0minesAndStart.png");
                                }
                            }
                            else
                            {
                                if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_1))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\1mine.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_2))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\2mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_3))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\3mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_4))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\4mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_5))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\5mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_6))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\6mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_7))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\7mines.png");
                                }
                                else if (grid.isOf(x, y, MSTileProperty.MINE_COUNT_8))
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\8mines.png");
                                }
                                else
                                {
                                    pbGrid[width*x + y].Image = Image.FromFile("pictures\\0mines.png");
                                }
                            }
                        }
                        else
                        {
                            if (grid.isOf(x, y, MSTileProperty.SNAKE))
                            {
                                pbGrid[width*x + y].Image = Image.FromFile("pictures\\snake.png");
                            }
                            else if (grid.isOf(x, y, MSTileProperty.FOOD))
                            {
                                pbGrid[width*x + y].Image = Image.FromFile("pictures\\food.png");
                            }
                            else if (grid.isOf(x, y, MSTileProperty.OBSTACLE))
                            {
                                pbGrid[width*x + y].Visible = false;
                            }
                            else
                            {
                                pbGrid[width*x + y].Image = Image.FromFile("pictures\\closed.png");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (y > 0)
                        {
                            y--;
                        }
                        if (x > 0)
                        {
                            x--;
                        }
                    }
                }
            }
        }

        private void bad(MSException e)
        {
            int height = grid.getHeight();
            int width = grid.getWidth();
            switch (e.Message)
            {
                case "SNAKE_ON_A_MINE":
                    pbGrid[width*xCritical + yCritical].Image = Image.FromFile("pictures\\bombAndSnake.jpg");
                    break;
                case "USER_ERROR_CLICKED_ON_MINE":
                    pbGrid[width*xCritical + yCritical].Image = Image.FromFile("pictures\\bomb.jpg");
                    break;
                case "USER_ERROR_MISSED_MINE":
                    pbGrid[width*xCritical + yCritical].Image = Image.FromFile("pictures\\noMine.png");
                    break;
                default:
                    break;
            }

            minesLeft = -1;
        }


        public void prepare(int gridWidth, int gridHeight, int snakeLength, int startX, int startY,
            List<int> obstacleXs, List<int> obstacleYs, int numberOfMines,
            int snakeMovesPerTenSeconds, PictureBox[] pbGr, bool[] visGr)
        {
            grid = new MSGrid(gridHeight, gridWidth);
            int height = grid.getHeight();
            int width = grid.getWidth();
            snake = new MSSnake(snakeLength);
            snake.setGrid(grid);
            grid.setTile(startX, startY, MSTileProperty.START);
            grid.setTiles(obstacleXs, obstacleYs, MSTileProperty.OBSTACLE);
            pbGrid = pbGr;
            visitedGrid = visGr;
            visitedGrid[width*startX + startY] = true;
            timer = new MSTimer(10000 / snakeMovesPerTenSeconds);
            Action f = () => { snake.move(1); paint(); points--; };
            timer.setFunction(f);
            Action<MSException> ef = e => onRuntimeException(e);
            timer.setErrorFunction(ef);

            minesLeft = numberOfMines;

            Random r = new Random();

            while (numberOfMines > 0)
            {
                int xc = r.Next() % gridHeight;
                int yc = r.Next() % gridWidth;

                if (grid.isOf(xc, yc, MSTileProperty.OBSTACLE) || grid.isOf(xc, yc, MSTileProperty.START) || grid.isOf(xc, yc, MSTileProperty.MINE))
                {
                    continue;
                }

                grid.addProperty(xc, yc, MSTileProperty.MINE);
                numberOfMines--;
            }

            for (int x = 0; x < gridHeight; x++)
            {
                for (int y = 0; y < gridWidth; y++)
                {
                    if (!grid.isOf(x, y, MSTileProperty.OBSTACLE))
                    {
                        int n = countMines(x, y);

                        switch (n)
                        {
                            case 1:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_1);
                                break;
                            case 2:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_2);
                                break;
                            case 3:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_3);
                                break;
                            case 4:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_4);
                                break;
                            case 5:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_5);
                                break;
                            case 6:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_6);
                                break;
                            case 7:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_7);
                                break;
                            case 8:
                                grid.addProperty(x, y, MSTileProperty.MINE_COUNT_8);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            grid.removeProperty(startX, startY, MSTileProperty.MINE);

            ai.setGrid(grid);
            ai.setSnake(snake);
        }

        public void play(int x)
        {
            grid.spawnFood();
            snake.setDirections(ai.getDirections(grid, grid.getStart()));

            paint();

            timer.start(x);
        }

        public void repaint()
        {
            paint();
        }

        public int checkResult()
        {
            if (minesLeft < 0)
            {
                return -1;
            }

            if (minesLeft == 0)
            {
                timer.stop();
                return 0;
            }


            return 1;
        }

        public void standardOpen(int x, int y, bool mc)
        {
            int height = grid.getHeight();
            int width = grid.getWidth();
            if (!grid.isIncluded(x, y) || visitedGrid[width*x + y] || grid.isOf(x, y, MSTileProperty.OBSTACLE) || minesLeft <= 0)
            {
                return;
            }

            if (grid.isOf(x, y, MSTileProperty.MINE))
            {
                timer.stop();
                paint();
                xCritical = x;
                yCritical = y;
                errFunc(new MSException("USER_ERROR_CLICKED_ON_MINE"));
                return;
            }

            visitedGrid[width*x + y] = true;

            if (!(grid.isOf(x, y, MSTileProperty.MINE_COUNT_1) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_2) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_3) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_4) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_5) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_6) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_7) || grid.isOf(x, y, MSTileProperty.MINE_COUNT_8)))
            {
                if (grid.isIncluded(x - 1, y - 1))
                {
                    standardOpen(x - 1, y - 1, false);
                }
                if (grid.isIncluded(x - 1, y))
                {
                    standardOpen(x - 1, y, false);
                }
                if (grid.isIncluded(x - 1, y + 1))
                {
                    standardOpen(x - 1, y + 1, false);
                }
                if (grid.isIncluded(x, y - 1))
                {
                    standardOpen(x, y - 1, false);
                }
                if (grid.isIncluded(x, y + 1))
                {
                    standardOpen(x, y + 1, false);
                }
                if (grid.isIncluded(x + 1, y - 1))
                {
                    standardOpen(x + 1, y - 1, false);
                }
                if (grid.isIncluded(x + 1, y))
                {
                    standardOpen(x + 1, y, false);
                }
                if (grid.isIncluded(x + 1, y + 1))
                {
                    standardOpen(x + 1, y + 1, false);
                }
            }

            if (mc)
            {
                paint();
            }
        }


        public void specialOpen(int x, int y)
        {
            int height = grid.getHeight();
            int width = grid.getWidth();
            if (!grid.isIncluded(x, y) || visitedGrid[width*x + y] || grid.isOf(x, y, MSTileProperty.OBSTACLE) || minesLeft <= 0)
            {
                return;
            }

            if (!grid.isOf(x, y, MSTileProperty.MINE))
            {
                timer.stop();
                paint();
                xCritical = x;
                yCritical = y;
                errFunc(new MSException("USER_ERROR_MISSED_MINE"));
                return;
            }

            visitedGrid[width*x + y] = true;
            removeAndRefresh(x, y);
            points += 15;
            paint();
        }

        public bool isOf(int x, int y, MSTileProperty p)
        {
            if (!grid.isIncluded(x, y))
            {
                return false;
            }

            return grid.isOf(x, y, p);
        }

        public MSGrid getGrid()
        {
            return grid;
        }

        public int getPoints()
        {
            return points;
        }

        public void removeAndRefresh(int x, int y)
        {
            if (grid.isIncluded(x, y) && grid.isOf(x, y, MSTileProperty.MINE))
            {
                grid.removeProperty(x, y, MSTileProperty.MINE);
                minesLeft--;

                if (grid.isIncluded(x - 1, y - 1))
                {
                    grid.decreaseMineCount(x - 1, y - 1);
                }
                if (grid.isIncluded(x - 1, y))
                {
                    grid.decreaseMineCount(x - 1, y);
                }
                if (grid.isIncluded(x - 1, y + 1))
                {
                    grid.decreaseMineCount(x - 1, y + 1);
                }
                if (grid.isIncluded(x, y - 1))
                {
                    grid.decreaseMineCount(x, y - 1);
                }
                if (grid.isIncluded(x, y + 1))
                {
                    grid.decreaseMineCount(x, y + 1);
                }
                if (grid.isIncluded(x + 1, y - 1))
                {
                    grid.decreaseMineCount(x + 1, y - 1);
                }
                if (grid.isIncluded(x + 1, y))
                {
                    grid.decreaseMineCount(x + 1, y);
                }
                if (grid.isIncluded(x + 1, y + 1))
                {
                    grid.decreaseMineCount(x + 1, y + 1);
                }
            }
        }

    }
}
