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
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        public Form1()
        {
            InitializeComponent();
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
            if(TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        // 회원가입 버튼 클릭 시 화면 띄우기 
        private void signButton_Click(object sender, EventArgs e)
        {
            Form2 showForm2 = new Form2(manager);
            showForm2.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*만약에 맞다면*/
            if (manager.LoginUser(userName.Text))
            {
                this.Visible = false;           
                Main showMain = new Main(manager);           
                showMain.ShowDialog();
            } else
            {
                MessageBox.Show("중복된 아이디거나 회원가입이 필요합니다.");
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            userName.Text = "";
        }



        // 버튼 클릭 시 종료
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        

    }
}
