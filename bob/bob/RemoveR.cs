using bob.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bob
{
    public partial class RemoveR : Form
    {
        Manager manager;
        public RemoveR(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }
        // 마우스 이동
        bool TagMove;
        int MValX, MValY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*만약 db에 이런게 있고 null이 아니면*/
            if (manager.RemoveRestaurant(textBox1.Text, cate.SelectedItem.ToString()))
            {
                MessageBox.Show("식당 삭제 완료 !");
                Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
