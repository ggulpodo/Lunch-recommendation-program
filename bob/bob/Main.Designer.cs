
namespace bob
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.no_etc = new System.Windows.Forms.CheckBox();
            this.no_west = new System.Windows.Forms.CheckBox();
            this.no_jp = new System.Windows.Forms.CheckBox();
            this.no_cn = new System.Windows.Forms.CheckBox();
            this.no_kor = new System.Windows.Forms.CheckBox();
            this.etc = new System.Windows.Forms.CheckBox();
            this.western = new System.Windows.Forms.CheckBox();
            this.japanese = new System.Windows.Forms.CheckBox();
            this.chinese = new System.Windows.Forms.CheckBox();
            this.korean = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.viewRButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecommandButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.no_etc);
            this.panel1.Controls.Add(this.no_west);
            this.panel1.Controls.Add(this.no_jp);
            this.panel1.Controls.Add(this.no_cn);
            this.panel1.Controls.Add(this.no_kor);
            this.panel1.Controls.Add(this.etc);
            this.panel1.Controls.Add(this.western);
            this.panel1.Controls.Add(this.japanese);
            this.panel1.Controls.Add(this.chinese);
            this.panel1.Controls.Add(this.korean);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.viewRButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RecommandButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // no_etc
            // 
            this.no_etc.AutoSize = true;
            this.no_etc.Location = new System.Drawing.Point(445, 229);
            this.no_etc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_etc.Name = "no_etc";
            this.no_etc.Size = new System.Drawing.Size(59, 19);
            this.no_etc.TabIndex = 25;
            this.no_etc.Text = "기타";
            this.no_etc.UseVisualStyleBackColor = true;
            // 
            // no_west
            // 
            this.no_west.AutoSize = true;
            this.no_west.Location = new System.Drawing.Point(373, 229);
            this.no_west.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_west.Name = "no_west";
            this.no_west.Size = new System.Drawing.Size(59, 19);
            this.no_west.TabIndex = 24;
            this.no_west.Text = "양식";
            this.no_west.UseVisualStyleBackColor = true;
            // 
            // no_jp
            // 
            this.no_jp.AutoSize = true;
            this.no_jp.Location = new System.Drawing.Point(301, 229);
            this.no_jp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_jp.Name = "no_jp";
            this.no_jp.Size = new System.Drawing.Size(59, 19);
            this.no_jp.TabIndex = 23;
            this.no_jp.Text = "일식";
            this.no_jp.UseVisualStyleBackColor = true;
            // 
            // no_cn
            // 
            this.no_cn.AutoSize = true;
            this.no_cn.Location = new System.Drawing.Point(229, 229);
            this.no_cn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_cn.Name = "no_cn";
            this.no_cn.Size = new System.Drawing.Size(59, 19);
            this.no_cn.TabIndex = 22;
            this.no_cn.Text = "중식";
            this.no_cn.UseVisualStyleBackColor = true;
            // 
            // no_kor
            // 
            this.no_kor.AutoSize = true;
            this.no_kor.Location = new System.Drawing.Point(158, 229);
            this.no_kor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.no_kor.Name = "no_kor";
            this.no_kor.Size = new System.Drawing.Size(59, 19);
            this.no_kor.TabIndex = 21;
            this.no_kor.Text = "한식";
            this.no_kor.UseVisualStyleBackColor = true;
            // 
            // etc
            // 
            this.etc.AutoSize = true;
            this.etc.Location = new System.Drawing.Point(445, 196);
            this.etc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.etc.Name = "etc";
            this.etc.Size = new System.Drawing.Size(59, 19);
            this.etc.TabIndex = 20;
            this.etc.Text = "기타";
            this.etc.UseVisualStyleBackColor = true;
            // 
            // western
            // 
            this.western.AutoSize = true;
            this.western.Location = new System.Drawing.Point(373, 196);
            this.western.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.western.Name = "western";
            this.western.Size = new System.Drawing.Size(59, 19);
            this.western.TabIndex = 19;
            this.western.Text = "양식";
            this.western.UseVisualStyleBackColor = true;
            // 
            // japanese
            // 
            this.japanese.AutoSize = true;
            this.japanese.Location = new System.Drawing.Point(301, 196);
            this.japanese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.japanese.Name = "japanese";
            this.japanese.Size = new System.Drawing.Size(59, 19);
            this.japanese.TabIndex = 18;
            this.japanese.Text = "일식";
            this.japanese.UseVisualStyleBackColor = true;
            // 
            // chinese
            // 
            this.chinese.AutoSize = true;
            this.chinese.Location = new System.Drawing.Point(229, 196);
            this.chinese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chinese.Name = "chinese";
            this.chinese.Size = new System.Drawing.Size(59, 19);
            this.chinese.TabIndex = 17;
            this.chinese.Text = "중식";
            this.chinese.UseVisualStyleBackColor = true;
            // 
            // korean
            // 
            this.korean.AutoSize = true;
            this.korean.Location = new System.Drawing.Point(158, 196);
            this.korean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.korean.Name = "korean";
            this.korean.Size = new System.Drawing.Size(59, 19);
            this.korean.TabIndex = 16;
            this.korean.Text = "한식";
            this.korean.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(112, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "오늘 여기는 진짜 아니다 :";
            // 
            // viewRButton
            // 
            this.viewRButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.viewRButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.viewRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewRButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.viewRButton.Location = new System.Drawing.Point(232, 431);
            this.viewRButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewRButton.Name = "viewRButton";
            this.viewRButton.Size = new System.Drawing.Size(137, 50);
            this.viewRButton.TabIndex = 15;
            this.viewRButton.Text = "식당 조회";
            this.viewRButton.UseVisualStyleBackColor = false;
            this.viewRButton.Click += new System.EventHandler(this.viewR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.textBox1.Location = new System.Drawing.Point(303, 300);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 33);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "식당명을 입력하세요.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(103, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "제외 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(103, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "선호 :";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(237, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 2);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(231, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "오 점 뭐 ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecommandButton
            // 
            this.RecommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.RecommandButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.RecommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecommandButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecommandButton.ForeColor = System.Drawing.Color.White;
            this.RecommandButton.Location = new System.Drawing.Point(232, 488);
            this.RecommandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecommandButton.Name = "RecommandButton";
            this.RecommandButton.Size = new System.Drawing.Size(137, 50);
            this.RecommandButton.TabIndex = 6;
            this.RecommandButton.Text = "추천 받기";
            this.RecommandButton.UseVisualStyleBackColor = false;
            this.RecommandButton.Click += new System.EventHandler(this.RecommandButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecommandButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewRButton;
        private System.Windows.Forms.CheckBox no_etc;
        private System.Windows.Forms.CheckBox no_west;
        private System.Windows.Forms.CheckBox no_jp;
        private System.Windows.Forms.CheckBox no_cn;
        private System.Windows.Forms.CheckBox no_kor;
        private System.Windows.Forms.CheckBox etc;
        private System.Windows.Forms.CheckBox western;
        private System.Windows.Forms.CheckBox japanese;
        private System.Windows.Forms.CheckBox chinese;
        private System.Windows.Forms.CheckBox korean;
    }
}