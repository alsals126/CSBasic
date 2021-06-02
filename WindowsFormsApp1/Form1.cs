using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Button buttonTemp;
            for (int i = 0; i < 5; i++)
            {
                buttonTemp = new Button();
                buttonTemp.Text = "버튼" + i;
                buttonTemp.Location = new Point(13, 13 + 23 + 23 + 25 * i);
                buttonTemp.Width = 100 + i * 20;
                Controls.Add(buttonTemp);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value < 20)
                trackBar1.Value = 20;
            this.Opacity = trackBar1.Value / 100.0;
        }

    }
}
