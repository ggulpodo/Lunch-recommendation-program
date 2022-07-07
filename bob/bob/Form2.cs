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
    public partial class Form2 : Form
    {
        Manager m;
        public Form2(Manager manager)
        {
            InitializeComponent();
            m = manager;
        }

        // 마우스 이동
        bool TagMove;
        int MValX, MValY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX=e.X;
            MValY=e.Y;
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
            m.SignUpuser(userName.Text);
            MessageBox.Show("회원가입 완료 !");
            Close();
        }

        private void userName_Enter(object sender, EventArgs e)
        { 
            userName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
