
namespace bob
{
    partial class ViewR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.removeRB = new System.Windows.Forms.Button();
            this.addRB = new System.Windows.Forms.Button();
            this.RestaurantList = new System.Windows.Forms.DataGridView();
            this.signButton = new System.Windows.Forms.Button();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.userId = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.toDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.removeRB);
            this.panel1.Controls.Add(this.addRB);
            this.panel1.Controls.Add(this.RestaurantList);
            this.panel1.Controls.Add(this.signButton);
            this.panel1.Controls.Add(this.checkedListBox3);
            this.panel1.Controls.Add(this.userId);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "추천일 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "-";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(247, 156);
            this.toDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(129, 25);
            this.toDate.TabIndex = 32;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(99, 156);
            this.fromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(129, 25);
            this.fromDate.TabIndex = 31;
            // 
            // removeRB
            // 
            this.removeRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.removeRB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.removeRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRB.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeRB.ForeColor = System.Drawing.Color.White;
            this.removeRB.Location = new System.Drawing.Point(304, 431);
            this.removeRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeRB.Name = "removeRB";
            this.removeRB.Size = new System.Drawing.Size(65, 50);
            this.removeRB.TabIndex = 30;
            this.removeRB.Text = "-";
            this.removeRB.UseVisualStyleBackColor = false;
            this.removeRB.Click += new System.EventHandler(this.removeRB_Click);
            // 
            // addRB
            // 
            this.addRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.addRB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.addRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRB.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addRB.ForeColor = System.Drawing.Color.White;
            this.addRB.Location = new System.Drawing.Point(232, 431);
            this.addRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRB.Name = "addRB";
            this.addRB.Size = new System.Drawing.Size(65, 50);
            this.addRB.TabIndex = 29;
            this.addRB.Text = "+";
            this.addRB.UseVisualStyleBackColor = false;
            this.addRB.Click += new System.EventHandler(this.addRB_Click);
            // 
            // RestaurantList
            // 
            this.RestaurantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantList.Location = new System.Drawing.Point(40, 242);
            this.RestaurantList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RestaurantList.Name = "RestaurantList";
            this.RestaurantList.RowHeadersWidth = 51;
            this.RestaurantList.RowTemplate.Height = 23;
            this.RestaurantList.Size = new System.Drawing.Size(515, 165);
            this.RestaurantList.TabIndex = 28;
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.signButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.signButton.Location = new System.Drawing.Point(232, 488);
            this.signButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(137, 50);
            this.signButton.TabIndex = 27;
            this.signButton.Text = "창 닫기";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox3.ColumnWidth = 85;
            this.checkedListBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "한식",
            "중식",
            "일식",
            "양식",
            "기타"});
            this.checkedListBox3.Location = new System.Drawing.Point(40, 203);
            this.checkedListBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox3.MultiColumn = true;
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(530, 24);
            this.checkedListBox3.TabIndex = 26;
            // 
            // userId
            // 
            this.userId.BackColor = System.Drawing.Color.White;
            this.userId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userId.FormattingEnabled = true;
            this.userId.Location = new System.Drawing.Point(392, 154);
            this.userId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(102, 29);
            this.userId.TabIndex = 22;
            this.userId.Text = "추천인";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(498, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 31);
            this.button3.TabIndex = 21;
            this.button3.Text = "조회";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(237, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 2);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(231, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "오 점 뭐 ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.Location = new System.Drawing.Point(560, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ViewR_Load);
            // 
            // ViewR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewR";
            this.Text = "ViewR";
            this.Load += new System.EventHandler(this.ViewR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox userId;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.DataGridView RestaurantList;
        private System.Windows.Forms.Button removeRB;
        private System.Windows.Forms.Button addRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}