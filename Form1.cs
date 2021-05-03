using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if(tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level1 level1 = new Level1(tmp);
            level1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("players.txt");
            textBox2.Text = "";
            for(int i = 0; i < lines.Length; i++)
            {
                textBox2.AppendText(lines[i]);
                textBox2.AppendText("\r\n");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application is a combination of two still " +
                "popular games, Minesweeper and Snake. " +
                "At the beginning of each level, the starting " +
                "position and the position where the food is " +
                "located are set. The snake moves towards the food." +
                " The players' task is to clear the snake's trajectory of potential mines.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level2 level2 = new Level2(tmp);
            level2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level3 level3 = new Level3(tmp);
            level3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level4 level4 = new Level4(tmp);
            level4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level5 level5 = new Level5(tmp);
            level5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level6 level6 = new Level6(tmp);
            level6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level7 level7 = new Level7(tmp);
            level7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level8 level8 = new Level8(tmp);
            level8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level9 level9 = new Level9(tmp);
            level9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            if (tmp.Trim().Equals(""))
            {
                MessageBox.Show("YOU HAVE TO ENTER YOUR NAME!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Level10 level10 = new Level10(tmp);
            level10.Show();
        }
    }
}
