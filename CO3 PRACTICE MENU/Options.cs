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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        public void Boarderless_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
        }

        private void Boardered_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            CenterToScreen();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    
}
