using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsBasic7_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 도움ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("가짜 메모장~");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value + 10 < toolStripProgressBar1.Maximum)
                toolStripProgressBar1.Value += 10;
            else
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            상태표시줄ToolStripMenuItem.Checked = !상태표시줄ToolStripMenuItem.Checked;
            if (상태표시줄ToolStripMenuItem.Checked)
                statusStrip1.Visible = true;
            else
                statusStrip1.Visible = false;
        }
    }
}
