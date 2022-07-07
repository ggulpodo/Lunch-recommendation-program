using bob.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.

namespace bob
{
    public partial class Main : Form
    {
        Manager m;
        public Main(Manager manager)
        {
            InitializeComponent();
            m = manager;
        }

        // 마우스 이동
        bool TagMove;
        int MValX, MValY;
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }


        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void viewR_Click(object sender, EventArgs e)
        {
            ViewR showViewR = new ViewR(m);
            showViewR.Show();
        }

        // 추천 받기 버튼 클릭시 화면전환
        private void RecommandButton_Click(object sender, EventArgs e)
        {
            var kor = "";
            var cn = "";
            var jp = "";
            var wt = "";
            var etc = "";
            if (korean.Checked == true)
            {
                kor = "선호";
            }
            else if (no_kor.Checked == true)
            {
                kor = "불호";
            }
            else
            {
                kor = "일반";
            }
            if (chinese.Checked == true)
            {
                cn = "선호";
            }
            else if (no_cn.Checked == true)
            {
                cn = "불호";
            }
            else
            {
                cn = "일반";
            }
            if (japanese.Checked == true)
            {
                jp = "선호";
            }
            else if (no_jp.Checked == true)
            {
                jp = "불호";
            }
            else
            {
                jp = "일반";
            }
            if (western.Checked == true)
            {
                wt = "선호";
            }
            else if (no_west.Checked == true)
            {
                wt = "불호";
            }
            else
            {
                wt = "일반";
            }
            if (this.etc.Checked == true)
            {
                etc = "선호";
            }
            else if (no_etc.Checked == true)
            {
                etc = "불호";
            }
            else
            {
                etc = "일반";
            }

            string q = $@"
            SELECT seqr, namer, category, signature, selecteddate
            FROM
	            (
	            SELECT RRL.seqr, namer, category, signature, count, selecteddate, date_count_point, Category_point, DATE_COUNT_POINT * CATEGORY_POINT AS POINT
            	FROM
		            (
		            SELECT r.*, s.selecteddate, s.userid,
			            CASE
			            	WHEN s.selecteddate IS NULL THEN (TRUNC(SYSDATE)-ADD_MONTHS(TRUNC(SYSDATE),-1))
		            		WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN ((-7 + TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) * r.COUNT)
		            		ELSE (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) * r.COUNT
		            	END AS DATE_COUNT_POINT,
		            	CASE
			            	WHEN r.CATEGORY = '중식' THEN
                                       CASE
				            	WHEN '선호' = '{cn}' THEN
                                       CASE
					            	WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN 0.1
					            	WHEN s.selecteddate IS NULL THEN 4
					            	ELSE 3
				            	END
				            	ELSE 1
			            	END
			            	WHEN R.CATEGORY = '한식' THEN
                                      CASE
				            	WHEN '선호' = '{kor}' THEN
                                 CASE
					            	WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN 0.1
					            	WHEN s.selecteddate IS NULL THEN 4
		            				ELSE 3
	            				END
	            				ELSE 1
	            			END
	            			WHEN r.CATEGORY = '일식' THEN
                        CASE
	            				WHEN '선호' = '{jp}' THEN
                        CASE
			            			WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN 0.1
			            			WHEN s.selecteddate IS NULL THEN 4
			            			ELSE 3
			            		END
			            		ELSE 1
	            			END
	            			WHEN r.CATEGORY = '양식' THEN
                        CASE
					            WHEN '선호' = '{wt}' THEN
                        CASE
						            WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN 0.1
						            WHEN s.selecteddate IS NULL THEN 4
						            ELSE 3
					            END
					            ELSE 1
				            END
				            WHEN r.CATEGORY = '기타' THEN
                                         CASE
					            WHEN '선호' = '{etc}' THEN
                                         CASE
						            WHEN (TRUNC(SYSDATE)-TO_DATE(substr(s.selecteddate, 0, 10), 'YYYY-MM-DD')) <= 7 THEN 0.1
						            WHEN s.selecteddate IS NULL THEN 4
						            ELSE 3
					            END
					            ELSE 1
				            END
			            END AS CATEGORY_POINT
		            FROM
			            RL r,
			            (
			            SELECT * FROM SELECTEDR
			            WHERE
				            (SEQR , USERid, selecteddate) IN (
				            SELECT
					            SEQR,
					            USERID ,
					            max(selecteddate)
				            FROM
					            SELECTEDR
				            GROUP BY
					            SEQR ,
					            USERID)
			            ORDER BY
				            selecteddate DESC) s
		            WHERE
			            1 = 1 {blackRest()}
			            AND r.SEQR = s.SEQR(+)
			            AND s.USERID(+)= '{m.getMyID()}'
			            AND (
                                ('불호' <> '{cn}'
				            AND R.CATEGORY = '중식')
			            OR ('불호' <> '{kor}'
				            AND R.CATEGORY = '한식')
			            OR ('불호' <> '{jp}'
				            AND R.CATEGORY = '일식')
			            OR ('불호' <> '{wt}'
				            AND R.CATEGORY = '양식')
			            OR ('불호' <> '{etc}'
				            AND R.CATEGORY = '기타')
                                )
		            ORDER BY
			            r.SEQR) RRL
	            ORDER BY
		            POINT DESC)
            WHERE
	            rownum <= 5
            ORDER BY
	            DBMS_RANDOM.RANDOM
                        )";

            Final showFinal = new Final(m, q);
            showFinal.ShowDialog();
        }

        // 불호
        public string blackRest()
        {
            if (textBox1.Text == null)
            {
                return "";
            }
            else
            {
                string black = "And r.namer not in ('"+ textBox1.Text+"')";
                return black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // X창
        private void button1_Click(object sender, EventArgs e)
        {
            m.LogoutUser();
            Application.Exit();
        }

    }
}
