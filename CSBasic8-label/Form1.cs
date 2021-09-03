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
        GroupBox groupBox1;
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

            groupBox1 = new GroupBox() { Text = "식물", Size = new Size(120, 100), Location = new Point(250, 10) };
            RadioButton radio1 = new RadioButton() { Text = "감자", Location = new Point(10, 10) };
            RadioButton radio2 = new RadioButton() { Text = "고구마", Location = new Point(10, 40) };
            RadioButton radio3 = new RadioButton() { Text = "토마토", Location = new Point(10, 70) };

            GroupBox groupBox2 = new GroupBox() { Text = "고기", Size = new Size(120, 100), Location = new Point(370, 10) };
            RadioButton radio4 = new RadioButton() { Text = "탕수육", Location = new Point(10, 10) };
            RadioButton radio5 = new RadioButton() { Text = "갈비", Location = new Point(10, 40) };
            RadioButton radio6 = new RadioButton() { Text = "치킨", Location = new Point(10, 70) };

            Button radioButton = new Button() { Text = "라디오", Location = new Point(250, 120) };
            groupBox1.Controls.Add(radio1);
            groupBox1.Controls.Add(radio2);
            groupBox1.Controls.Add(radio3);
            groupBox2.Controls.Add(radio4);
            groupBox2.Controls.Add(radio5);
            groupBox2.Controls.Add(radio6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(radioButton);
            radioButton.Click += radioButtonClick;
        }

        private void radioButtonClick(object sender, EventArgs e)
        {
            foreach(RadioButton item1 in groupBox1.Controls)
            {
                if(item1.Checked)
                {
                    MessageBox.Show(item1.Text);
                }
            }

            foreach (var outerItem in Controls)
            {
                if (outerItem is GroupBox)
                {
                    GroupBox gb = outerItem as GroupBox;
                    foreach (var item in gb.Controls)
                    {
                        if (item is RadioButton && (item as RadioButton).Checked)
                        {
                            MessageBox.Show((item as RadioButton).Text);
                        }
                    }
                }
            }
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
