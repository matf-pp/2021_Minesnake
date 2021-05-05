#ifndef __MANAGER__
#define __MANAGER__

#include <vector>
#include <string>
#include <functional>
#include <cstdlib>
#include <algorithm>
#include <ctime>
#include "MSGrid.cpp"
#include "MSSnake.cpp"
#include "MSTileProperty.cpp"
#include "MSTimer.cpp"
#include "MSSnakeAI.cpp"
#include "MSException.cpp"

using namespace System;
using namespace System::Windows::Forms;
using namespace System::Drawing;

// A class representing mediator between backend and GUI.
class MSManager {
private:
	MSGrid grid;
	MSSnake snake;
	MSTimer timer;
	std::function<void()> paint = [this]() {imagine();};
	std::function<void(MSException)> errFunc = [this](MSException e) {bad(e);};
	MSSnakeAI ai;
	PictureBox^* pbGrid;
	bool* visitedGrid;
	int xCritical;
	int yCritical;
	int minesLeft;
	int points = 0;

 
	// Counts number of tiles surrounding the tile on given coordinates that contain mine property, if those are valid; otherwise returns 0.
	int countMines(int x, int y) {
		if (grid.isIncluded(x, y)) {
			int count = 0;

			for (auto t : grid.getNeighbourhood(x, y)) {
				if (t.isOf(MSTileProperty::MINE)) {
					count ++;
				}
			}

			return count;
		}

		return 0;
	}

	// Method that determines what happens in case of exception being thrown in middle-game.
	void onRuntimeException(MSException e) {
		if (e == MSException::SNAKE_ON_A_MINE) {
			timer.stop();
			paint();
			auto hc = snake.getHeadCoordinates();
			xCritical = std::get<0>(hc);
			yCritical = std::get<1>(hc);
			errFunc(e);
		} else if (e == MSException::SNAKE_IN_INVALID_POSITION) {
			snake.reset();
			snake.setDirections(ai.getDirections());
			paint();
			timer.resume();
		} else if (e == MSException::SNAKE_ON_FOOD) {
			std::pair<int, int> hc;
	
			try {
				hc = snake.getHeadCoordinates();
			}
			catch (MSException e) {
				timer.stop();
				errFunc(e);
			}
	
			grid.removeProperty(std::get<0>(hc), std::get<1>(hc), MSTileProperty::FOOD);
			grid.spawnFood();

			points -= 40;

			snake.setDirections(ai.getDirections());
			paint();
			timer.resume();
		}
	}

	// Paints the interface picture boxes.
	void imagine() {
		int height = grid.getHeight();
		int width = grid.getWidth();

		for (int y = 0; y < width; y ++) {
			for (int x = 0; x < height; x ++) {
				try {
					if (visitedGrid[10 * x + y]) {
						if (grid.isOf(x, y, MSTileProperty::SNAKE)) {
							if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_1)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\1mineAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_2)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\2minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_3)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\3minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_4)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\4minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_5)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\5minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_6)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\6minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_7)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\7minesAndSnake.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_8)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\8minesAndSnake.png");
							}
							else {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\0minesAndSnake.png");
							}
						}
						else if (grid.isOf(x, y, MSTileProperty::FOOD)) {
							if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_1)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\1mineAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_2)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\2minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_3)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\3minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_4)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\4minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_5)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\5minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_6)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\6minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_7)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\7minesAndFood.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_8)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\8minesAndFood.png");
							}
							else {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\0minesAndFood.png");
							}
						}
						else if (grid.isOf(x, y, MSTileProperty::START)) {
							if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_1)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\1mineAndStart.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_2)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\2minesAndStart.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_3)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\3minesAndStart.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_4)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\4minesAndStart.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_5)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\5minesAndStart.png");
							}
							else {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\0minesAndStart.png");
							}
						}
						else {
							if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_1)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\1mine.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_2)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\2mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_3)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\3mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_4)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\4mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_5)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\5mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_6)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\6mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_7)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\7mines.png");
							}
							else if (grid.isOf(x, y, MSTileProperty::MINE_COUNT_8)) {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\8mines.png");
							}
							else {
								pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\0mines.png");
							}
						}
					}
					else {
						if (grid.isOf(x, y, MSTileProperty::SNAKE)) {
							pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\snake.png");
						}
						else if (grid.isOf(x, y, MSTileProperty::FOOD)) {
							pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\food.png");
						}
						else if (grid.isOf(x, y, MSTileProperty::OBSTACLE)) {
							pbGrid[10*x+y]->Visible = false;
						}
						else {
							pbGrid[10*x+y]->BackgroundImage = Image::FromFile("pictures\\closed.png");
						}
					}
				} catch (Exception^ e) {
					if (y > 0) {
						y--;
					}
					if (x > 0) {
						x--;
					}
				}
			}
		}
	}

	// Defines what happens if game-breaking situation occurs.
	void bad(MSException e) {
		switch (e) {
		case MSException::SNAKE_ON_A_MINE:
			pbGrid[10*xCritical + yCritical] -> BackgroundImage = Image::FromFile((String^)"pictures\\bombAndSnake.jpg");
			break;
		case USER_ERROR_CLICKED_ON_MINE:
			pbGrid[10*xCritical + yCritical] -> BackgroundImage = Image::FromFile((String^)"pictures\\bomb.jpg");
			break;
		case USER_ERROR_MISSED_MINE:
			pbGrid[10*xCritical + yCritical] -> BackgroundImage = Image::FromFile((String^)"pictures\\noMine.png");
			break;
		default:
			break;
		}

		minesLeft = -1;
	}

public:
	// Creates an empty manager.
	MSManager() {
	}

	// Prepares the manager by supplying it with necessary information.
	// Assumes the provided information to be valid.
	void prepare(int gridWidth, int gridHeight, int snakeLength, int startX, int startY,
		std::vector<int>& obstacleXs, std::vector<int>& obstacleYs, int numberOfMines,
		int snakeMovesPerTenSeconds, PictureBox^* pbGr, bool* visGr) {
		grid = MSGrid(gridHeight, gridWidth);
		snake = MSSnake(snakeLength);
		snake.setGrid(&grid);
		grid.setTile(startX, startY, MSTileProperty::START);
		grid.setTiles(obstacleXs, obstacleYs, MSTileProperty::OBSTACLE);
		pbGrid = pbGr;
		visitedGrid = visGr;
		visitedGrid[startX * 10 + startY] = true;
		timer = MSTimer(10000 / snakeMovesPerTenSeconds);
		timer.setFunction([this]() {
			snake.move(1);
			paint();
		});
		timer.setErrorFunction([this](MSException e) {
			onRuntimeException(e);
		});

		std::srand(std::time(nullptr));
		minesLeft = numberOfMines;

		for (int i = 0; i < numberOfMines; i ++) {
			int xc = std::rand() % gridHeight;
			int yc = std::rand() % gridWidth;

			if (grid.isOf(xc, yc, MSTileProperty::OBSTACLE) || grid.isOf(xc, yc, MSTileProperty::START) || grid.isOf(xc, yc, MSTileProperty::MINE)) {
				i --;
			} else {
				grid.addProperty(xc, yc, MSTileProperty::MINE);
			}
		}

		for (int x = 0; x < gridHeight; x ++) {
			for (int y = 0; y < gridWidth; y ++) {
				if (!grid.isOf(x, y, MSTileProperty::OBSTACLE)) {
					int n = countMines(x, y);

					switch (n) {
					case 1:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_1);
						break;
					case 2:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_2);
						break;
					case 3:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_3);
						break;
					case 4:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_4);
						break;
					case 5:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_5);
						break;
					case 6:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_6);
						break;
					case 7:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_7);
						break;
					case 8:
						grid.addProperty(x, y, MSTileProperty::MINE_COUNT_8);
						break;
					default:
						break;
					}
				}
			}
		}

		ai.setGrid(grid);
		ai.setSnake(snake);
	}

	// Method that starts a game, sleeping given number of millisecond only at the beginning.
	// Assumes that the game has already been prepared, i. e. that method 'prepare' has been succesfully called.
	void play(int x) {
		grid.spawnFood();
		snake.setDirections(ai.getDirections());

		paint();

		// timer.start(x);
	}

	// Calls painting function.
	void repaint() {
		snake.move(1);
		paint();
	}

	// Checks for the move result and returns 1 if nothing happened, 0 if there are no more mines left and -1 if illegal move was made.
	int checkResult() {
		if (minesLeft < 0) {
			return -1;
		}

		if (minesLeft == 0) {
			return 0;
		}

		if (minesLeft > 0) {
			return 1;
		}
	}

	// Defines action that occurs when tile on given coordinates is clicked with opening intention if those are valid; otherwise does nothing.
	// Repaints tiles only if master call option is set to true.
	void standardOpen(int x, int y, bool mc) {
		if (!grid.isIncluded(x, y) || visitedGrid[x * 10 + y] || grid.isOf(x, y, MSTileProperty::OBSTACLE) || minesLeft <= 0) {
			return;
		}

		if (grid.isOf(x, y, MSTileProperty::MINE)) {
			timer.stop();
			paint();
			xCritical = x;
			yCritical = y;
			errFunc(MSException::USER_ERROR_CLICKED_ON_MINE);
			return;
		}

		visitedGrid[x * 10 + y] = true;
		points += 3;

		if (!(grid.isOf(x, y, MSTileProperty::MINE_COUNT_1) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_2) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_3) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_4) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_5) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_6) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_7) || grid.isOf(x, y, MSTileProperty::MINE_COUNT_8))) {
			if (grid.isIncluded(x - 1, y - 1)) {
				standardOpen(x - 1, y - 1, false);
			}
			if (grid.isIncluded(x - 1, y)) {
				standardOpen(x - 1, y, false);
			}
			if (grid.isIncluded(x - 1, y + 1)) {
				standardOpen(x - 1, y + 1, false);
			}
			if (grid.isIncluded(x, y - 1)) {
				standardOpen(x, y - 1, false);
			}
			if (grid.isIncluded(x, y + 1)) {
				standardOpen(x, y + 1, false);
			}
			if (grid.isIncluded(x + 1, y - 1)) {
				standardOpen(x + 1, y - 1, false);
			}
			if (grid.isIncluded(x + 1, y)) {
				standardOpen(x + 1, y, false);
			}
			if (grid.isIncluded(x + 1, y + 1)) {
				standardOpen(x + 1, y + 1, false);
			}
		}

		if (mc) {
			paint();
		}
	}

	// Defines action that occurs when tile on given coordinates is clicked with mine-clearing intention if those are valid; otherwise does nothing.
	// Does repaint tile grid.
	void specialOpen(int x, int y) {
		if (!grid.isIncluded(x, y) || visitedGrid[x * 10 + y] || grid.isOf(x, y, MSTileProperty::OBSTACLE) || minesLeft <= 0) {
			return;
		}

		if (!grid.isOf(x, y, MSTileProperty::MINE)) {
			timer.stop();
			paint();
			xCritical = x;
			yCritical = y;
			errFunc(MSException::USER_ERROR_MISSED_MINE);
			return;
		}

		visitedGrid[x * 10 + y] = true;

		removeAndRefresh(x, y);
		paint();
	}

	// Checks whether tile on given coordinates is of given property, if those are valid; otherwise returns false.
	bool isOf(int x, int y, MSTileProperty p) {
		if (!grid.isIncluded(x, y)) {
			return false;
		}

		return grid.isOf(x, y, p);
	}

	// Returns pointer pointing to a grid.
	auto getGrid() {
		return &grid;
	}

	// Returns number of points currently won.
	int getPoints() {
		return points;
	}

	// Removes a mine from tile on given coordinates and refreshes that tile's surroundings, if those are valid and mine exists; otherwise does nothing.
	// This method does not call the painting function.
	void removeAndRefresh(int x, int y) {
		if (grid.isIncluded(x, y) && grid.isOf(x, y, MSTileProperty::MINE)) {
			grid.removeProperty(x, y, MSTileProperty::MINE);
			minesLeft --;
			points += 10;

			if (grid.isIncluded(x - 1, y - 1)) {
				grid.decreaseMineCount(x - 1, y - 1);
			}
			if (grid.isIncluded(x - 1, y)) {
				grid.decreaseMineCount(x - 1, y);
			}
			if (grid.isIncluded(x - 1, y + 1)) {
				grid.decreaseMineCount(x - 1, y + 1);
			}
			if (grid.isIncluded(x, y - 1)) {
				grid.decreaseMineCount(x, y - 1);
			}
			if (grid.isIncluded(x, y + 1)) {
				grid.decreaseMineCount(x, y + 1);
			}
			if (grid.isIncluded(x + 1, y - 1)) {
				grid.decreaseMineCount(x + 1, y - 1);
			}
			if (grid.isIncluded(x + 1, y)) {
				grid.decreaseMineCount(x + 1, y);
			}
			if (grid.isIncluded(x + 1, y + 1)) {
				grid.decreaseMineCount(x + 1, y + 1);
			}
		}
	}
};

#endif
