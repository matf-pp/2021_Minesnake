﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSnake
{
	public partial class Level8 : Form
	{
		private string name;
		private PictureBox[] pBoxes = new PictureBox[169];
		private bool[] visited = new bool[169];
		private MSManager game = new MSManager();

		public Level8(string name)
		{
			InitializeComponent();
			this.name = name;
		}

		private void Level8_Load(object sender, EventArgs e)
		{
			label3.Text = name;

			pBoxes[0] = pictureBox1;
			pBoxes[1] = pictureBox2;
			pBoxes[2] = pictureBox3;
			pBoxes[3] = pictureBox4;
			pBoxes[4] = pictureBox5;
			pBoxes[5] = pictureBox6;
			pBoxes[6] = pictureBox7;
			pBoxes[7] = pictureBox8;
			pBoxes[8] = pictureBox9;
			pBoxes[9] = pictureBox10;

			pBoxes[10] = pictureBox11;
			pBoxes[11] = pictureBox12;
			pBoxes[12] = pictureBox13;
			pBoxes[13] = pictureBox14;
			pBoxes[14] = pictureBox15;
			pBoxes[15] = pictureBox16;
			pBoxes[16] = pictureBox17;
			pBoxes[17] = pictureBox18;
			pBoxes[18] = pictureBox19;
			pBoxes[19] = pictureBox20;

			pBoxes[20] = pictureBox21;
			pBoxes[21] = pictureBox22;
			pBoxes[22] = pictureBox23;
			pBoxes[23] = pictureBox24;
			pBoxes[24] = pictureBox25;
			pBoxes[25] = pictureBox26;
			pBoxes[26] = pictureBox27;
			pBoxes[27] = pictureBox28;
			pBoxes[28] = pictureBox29;
			pBoxes[29] = pictureBox30;

			pBoxes[30] = pictureBox31;
			pBoxes[31] = pictureBox32;
			pBoxes[32] = pictureBox33;
			pBoxes[33] = pictureBox34;
			pBoxes[34] = pictureBox35;
			pBoxes[35] = pictureBox36;
			pBoxes[36] = pictureBox37;
			pBoxes[37] = pictureBox38;
			pBoxes[38] = pictureBox39;
			pBoxes[39] = pictureBox40;

			pBoxes[40] = pictureBox41;
			pBoxes[41] = pictureBox42;
			pBoxes[42] = pictureBox43;
			pBoxes[43] = pictureBox44;
			pBoxes[44] = pictureBox45;
			pBoxes[45] = pictureBox46;
			pBoxes[46] = pictureBox47;
			pBoxes[47] = pictureBox48;
			pBoxes[48] = pictureBox49;
			pBoxes[49] = pictureBox50;

			pBoxes[50] = pictureBox51;
			pBoxes[51] = pictureBox52;
			pBoxes[52] = pictureBox53;
			pBoxes[53] = pictureBox54;
			pBoxes[54] = pictureBox55;
			pBoxes[55] = pictureBox56;
			pBoxes[56] = pictureBox57;
			pBoxes[57] = pictureBox58;
			pBoxes[58] = pictureBox59;
			pBoxes[59] = pictureBox60;

			pBoxes[60] = pictureBox61;
			pBoxes[61] = pictureBox62;
			pBoxes[62] = pictureBox63;
			pBoxes[63] = pictureBox64;
			pBoxes[64] = pictureBox65;
			pBoxes[65] = pictureBox66;
			pBoxes[66] = pictureBox67;
			pBoxes[67] = pictureBox68;
			pBoxes[68] = pictureBox69;
			pBoxes[69] = pictureBox70;

			pBoxes[70] = pictureBox71;
			pBoxes[71] = pictureBox72;
			pBoxes[72] = pictureBox73;
			pBoxes[73] = pictureBox74;
			pBoxes[74] = pictureBox75;
			pBoxes[75] = pictureBox76;
			pBoxes[76] = pictureBox77;
			pBoxes[77] = pictureBox78;
			pBoxes[78] = pictureBox79;
			pBoxes[79] = pictureBox80;

			pBoxes[80] = pictureBox81;
			pBoxes[81] = pictureBox82;
			pBoxes[82] = pictureBox83;
			pBoxes[83] = pictureBox84;
			pBoxes[84] = pictureBox85;
			pBoxes[85] = pictureBox86;
			pBoxes[86] = pictureBox87;
			pBoxes[87] = pictureBox88;
			pBoxes[88] = pictureBox89;
			pBoxes[89] = pictureBox90;

			pBoxes[90] = pictureBox91;
			pBoxes[91] = pictureBox92;
			pBoxes[92] = pictureBox93;
			pBoxes[93] = pictureBox94;
			pBoxes[94] = pictureBox95;
			pBoxes[95] = pictureBox96;
			pBoxes[96] = pictureBox97;
			pBoxes[97] = pictureBox98;
			pBoxes[98] = pictureBox99;
			pBoxes[99] = pictureBox100;

			pBoxes[100] = pictureBox101;
			pBoxes[101] = pictureBox102;
			pBoxes[102] = pictureBox103;
			pBoxes[103] = pictureBox104;
			pBoxes[104] = pictureBox105;
			pBoxes[105] = pictureBox106;
			pBoxes[106] = pictureBox107;
			pBoxes[107] = pictureBox108;
			pBoxes[108] = pictureBox109;
			pBoxes[109] = pictureBox110;

			pBoxes[110] = pictureBox111;
			pBoxes[111] = pictureBox112;
			pBoxes[112] = pictureBox113;
			pBoxes[113] = pictureBox114;
			pBoxes[114] = pictureBox115;
			pBoxes[115] = pictureBox116;
			pBoxes[116] = pictureBox117;
			pBoxes[117] = pictureBox118;
			pBoxes[118] = pictureBox119;
			pBoxes[119] = pictureBox120;

			pBoxes[120] = pictureBox121;
			pBoxes[121] = pictureBox122;
			pBoxes[122] = pictureBox123;
			pBoxes[123] = pictureBox124;
			pBoxes[124] = pictureBox125;
			pBoxes[125] = pictureBox126;
			pBoxes[126] = pictureBox127;
			pBoxes[127] = pictureBox128;
			pBoxes[128] = pictureBox129;
			pBoxes[129] = pictureBox130;

			pBoxes[130] = pictureBox131;
			pBoxes[131] = pictureBox132;
			pBoxes[132] = pictureBox133;
			pBoxes[133] = pictureBox134;
			pBoxes[134] = pictureBox135;
			pBoxes[135] = pictureBox136;
			pBoxes[136] = pictureBox137;
			pBoxes[137] = pictureBox138;
			pBoxes[138] = pictureBox139;
			pBoxes[139] = pictureBox140;

			pBoxes[140] = pictureBox141;
			pBoxes[141] = pictureBox142;
			pBoxes[142] = pictureBox143;
			pBoxes[143] = pictureBox144;
			pBoxes[144] = pictureBox145;
			pBoxes[145] = pictureBox146;
			pBoxes[146] = pictureBox147;
			pBoxes[147] = pictureBox148;
			pBoxes[148] = pictureBox149;
			pBoxes[149] = pictureBox150;

			pBoxes[150] = pictureBox151;
			pBoxes[151] = pictureBox152;
			pBoxes[152] = pictureBox153;
			pBoxes[153] = pictureBox154;
			pBoxes[154] = pictureBox155;
			pBoxes[155] = pictureBox156;
			pBoxes[156] = pictureBox157;
			pBoxes[157] = pictureBox158;
			pBoxes[158] = pictureBox159;
			pBoxes[159] = pictureBox160;

			pBoxes[160] = pictureBox161;
			pBoxes[161] = pictureBox162;
			pBoxes[162] = pictureBox163;
			pBoxes[163] = pictureBox164;
			pBoxes[164] = pictureBox165;
			pBoxes[165] = pictureBox166;
			pBoxes[166] = pictureBox167;
			pBoxes[167] = pictureBox168;
			pBoxes[168] = pictureBox169;

			for (int i = 0; i < 169; i++)
				visited[i] = false;

			// Start of the game
			List<int> obstacleX = new List<int>() { 2, 7 };
			List<int> obstacleY = new List<int>() { 1, 5 };
			game.prepare(13, 13, 4, 0, 3, obstacleX, obstacleY, 15, 18, pBoxes, visited);
			game.repaint();
			game.play(1000);
		}

		private void updateFileContent()
		{
			string[] lines = System.IO.File.ReadAllLines("players.txt");
			List<string> fileContent = new List<string>();
			List<Tuple<string, int>> sortedList = new List<Tuple<string, int>>();
			foreach (string line in lines)
			{
				string[] tmp = line.Split(' ');
				sortedList.Add(new Tuple<string, int>(tmp[0], int.Parse(tmp[1])));
			}
			int points = game.getPoints();
			sortedList.Add(new Tuple<string, int>(name, points));

			sortedList.Sort((a, b) => b.Item2.CompareTo(a.Item2));

			int j = 0;
			foreach (Tuple<string, int> tmp in sortedList)
			{
				if (j == 5)
					break;
				fileContent.Add(tmp.Item1 + " " + tmp.Item2.ToString());
				j++;
			}

			System.IO.File.WriteAllLines("players.txt", fileContent);
		}

		private void pictureBox91_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to exit game?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
				this.Close();
		}

		private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(0, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(0, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox26_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(1, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(1, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox27_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox28_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox29_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox30_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox31_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox32_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox33_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox34_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox35_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox36_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox37_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox38_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox39_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(2, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(2, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox40_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox41_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox42_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox43_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox44_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox45_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox46_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox47_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox48_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox49_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox50_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox51_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox52_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(3, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(3, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox53_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox54_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox55_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox56_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox57_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox58_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox59_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox60_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox61_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox62_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox63_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox64_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox65_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(4, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(4, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox66_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox67_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox68_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox69_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox70_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox71_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox72_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox73_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox74_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox75_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox76_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox77_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox78_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(5, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(5, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox79_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox80_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox81_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox82_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox83_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox84_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox85_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox86_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox87_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox88_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox89_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox90_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox91_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(6, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(6, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox92_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox93_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox94_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox95_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox96_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox97_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox98_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox99_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox100_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox123_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox101_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox101_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox102_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox103_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox104_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(7, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(7, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox105_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox106_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox107_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox108_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox109_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox110_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox111_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox112_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox113_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox114_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox115_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox116_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox117_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(8, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(8, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox118_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox119_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox120_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox121_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox122_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox123_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox124_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox125_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox126_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox127_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox128_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox129_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox130_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(9, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(9, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox131_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox132_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox133_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox134_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox135_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox136_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox137_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox138_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox139_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox140_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox135_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox136_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox137_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox138_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox139_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox140_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox141_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox142_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox143_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(10, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(10, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox144_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox145_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox146_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox147_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox148_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox149_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox150_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox151_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox152_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox153_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox154_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox155_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(11, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(11, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox157_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 0, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 0);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox158_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 1, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 1);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox159_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 2, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 2);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox160_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 3, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 3);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox161_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 4, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 4);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox162_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 5, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 5);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox163_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 6, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 6);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox164_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 7, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 7);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox165_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 8, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 8);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox166_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 9, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 9);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox167_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 10, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 10);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox168_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 11, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 11);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

		private void pictureBox169_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				game.standardOpen(12, 12, true);
			}

			if (e.Button == MouseButtons.Right)
			{
				game.specialOpen(12, 12);
			}

			int result = game.checkResult();
			if (result == 0)
			{
				MessageBox.Show("YOU WIN. CONGRATS! :)"); updateFileContent(); 
			}
			else if (result == -1)
			{
				MessageBox.Show("YOU LOSE :("); updateFileContent(); 
			}
		}

        private void Level8_FormClosed(object sender, FormClosedEventArgs e)
        {
			Form1 form1 = new Form1();
			form1.Show();
		}
    }
}


