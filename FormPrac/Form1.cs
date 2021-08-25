using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = DialogResult.None; 
            if(btn == btnMessageBox1)
            {
                result = MessageBox.Show("안녕하세요~");
            }else if(btn == btnMessageBox2)
            {
                result = MessageBox.Show("안녕하세요!", "격하게 환영인사");
            }else if(btn == btnMessageBox3)
            {
                result = MessageBox.Show("안녕하세요~", "격하게 환영인사",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }

            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show("나도 반가워요😚");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("나도 안바가워요😒");
                    break;
            }
        }
    }
}
