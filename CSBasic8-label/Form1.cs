using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic8_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //기본적인 초기화

            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 10)
            };
            Controls.Add(label);

            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(10, 50)
            };
            Controls.Add(linkLabel);
            linkLabel.Click += LabelClick;

            CheckBox checkBox1 = new CheckBox() { Text = "감자", Location = new Point(130, 10) };
            CheckBox checkBox2 = new CheckBox() { Text = "고구마", Location = new Point(130, 40) };
            CheckBox checkBox3 = new CheckBox() { Text = "토마토", Location = new Point(130, 70) };
            Button button = new Button();
            button.Location = new Point(130, 100);
            button.Text = "클릭";
            button.Click += ButtonClick;
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }
            MessageBox.Show(string.Join(",", list));
        }

        private void LabelClick(object sender, EventArgs e) //이벤트 핸들러
        {
            System.Diagnostics.Process.Start("https://www.naver.com"); //windows+R 눌러서(실행창 실행) naver연거랑 똑같음
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
