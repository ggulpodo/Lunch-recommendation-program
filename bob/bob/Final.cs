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
    public partial class Final : Form
    {
        Manager m;
        DataRow drc;
        string q;

        public Final(Manager manager, string query)
        {
            InitializeComponent();
            m = manager;
            q = query;
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

        // 선택 완료가 되면 DB에 추천 횟수 증가되고 프로그램은 종료됨
        private void selectButton_Click(object sender, EventArgs e)
        {
            m.SelectedRest(drc[0].ToString());
            Application.Exit();
        }

        private void RRButton_Click(object sender, EventArgs e)
        {
            try
            {
                q += " and namer not in ('" + finalMenu.Text + "')";
                drc = m.RecommendRest(q).Tables[0].Rows[0];
                finalMenu.Text = drc[1].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("최대 5번까지 추천 받을 수 있습니다.");
                this.Visible = false;
            }
            
        }

        private void Final_Load(object sender, EventArgs e)
        {
            q += " where rownum<=1";
            q = "select * from (" + q;
            drc = m.RecommendRest(q).Tables[0].Rows[0];
            finalMenu.Text = drc[1].ToString();
        }



        // X 창
        private void button1_Click(object sender, EventArgs e)
        {
            m.LogoutUser();
            Close();
            //Application.Exit();
        }
    }
}
