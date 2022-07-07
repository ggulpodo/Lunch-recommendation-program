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
    public partial class ViewR : Form
    {
        Manager manager;
        public ViewR(Manager manager)
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

        // 창닫기 버튼 클릭
        private void signButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addRB_Click(object sender, EventArgs e)
        { 
            AddR showAddR = new AddR(manager); showAddR.ShowDialog();
        }

        private void removeRB_Click(object sender, EventArgs e)
        {
            RemoveR showRemoveR = new RemoveR(manager); showRemoveR.ShowDialog();
        }

        private void ViewR_Load(object sender, EventArgs e)
        {
            this.RestaurantList.DataSource = manager.ShowSelRest().Tables[0];
            this.RestaurantList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.userId.DataSource = manager.ShowUser().Tables[0];
            this.userId.DisplayMember = "USERID";
            this.userId.ValueMember = "USERID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.RestaurantList.DataSource = manager.ShowSelRest(fromDate.Value, toDate.Value, checkedListBox3.CheckedItems, userId.SelectedValue.ToString()).Tables[0];
        }


        // X버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
