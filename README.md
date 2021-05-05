<h1 style="font-size:60px;"> MineSnake - description </h1>

Minesnake is a project designed by three promising R students at the Faculty of Mathematics who are so modest that they had to advertise themselves at the very beginning of this description. The project is a combination of two still popular games, Minesweeper and Snake. We sincerely hope that there have been no such attempts to merge these two games so far.

Pictures used (some of them):

 - field where the mine is located; <img align="left" width="40" height="37" src="/project_files/pictures/1mine.png">

 - field where the snake is located; <img align="left" width="40" height="37" src="/project_files/pictures/snake.png">

 - field from which the snake starts; <img align="left" width="40" height="37" src="/project_files/pictures/0minesAndStart.png">
        
 - field where the food is found. <img align="left" width="40" height="37" src="/project_files/pictures/food.png">

Each of the fields can be found in the following three colors: gray, orange, and green.

Meaning of each color:

Gray - unmarked fields;

Orange - fields where food can be found;

Green - fields where the snake is located.
<p align="center">
<img width="800" height="500" src="/project_files/pictures/photo1.png"> 
</p>
  <p align="center"> <h1 style="font-size:30px;"> On the picture above you can see our front page </h1> </p>
  
-Before you run a level, you need to enter your name;

-On the rang list button, you will get a list of top five players;

-Click help, for a game introduction.

At the beginning of each level, the starting position and the position where the food is located are set. The snake moves towards the food. The players' task is to clear the snake's trajectory of potential mines.

The function which finds snake’s trajectory is based on well-known graph BFS algorithm. The algorithm should garant to find the shortest possible path in time complexity O(m*n) (where m and n are dimensions of the matrix).

The original idea was for the project to be done in C++, and almost entire code was typed in it, but we came across an error that we managed to fix by switching to C#.

An executable file was created for Microsoft Windows operating system. The project can be started using Windows forms in Visual Studio.
Some of the packages used are: System.Collection.Generic, System.Drawing, System.Text, System.Linq, System.Threading.Tasks, System.Windows.Forms.

Authors and their contact adresses: 

~Milica Karličić, mr18101@alas.matf.bg.ac.rs

~Branko Cvetković, mr18262@alas.matf.bg.ac.rs

~Petar Tešić, mr18002@alas.matf.bg.ac.rs 
