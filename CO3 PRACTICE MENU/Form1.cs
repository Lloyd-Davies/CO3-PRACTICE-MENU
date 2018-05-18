using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO3_PRACTICE_MENU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow Game = new GameWindow();
            Game.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Options Opt = new Options();
            Opt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
