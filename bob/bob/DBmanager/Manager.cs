using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using static System.Windows.Forms.CheckedListBox;

namespace bob.manager
{
    public class Manager
    {
        public string OleDBstring = string.Format("Provider=OraOLEDB.Oracle;" +
            "OLEDB.NET=true; " +
            "PLSQLRSet=true; " +
            "Data Source=xe; " +
            "User Id=ebjo; " +
            "Password=oraclejava;");

        public OleDbConnection connection = null;
        DBQuery dBQuery;
        string myID;

        public Manager()
        {
            connection = new OleDbConnection(OleDBstring);
            dBQuery = new DBQuery(connection);
        }

        public void setMyID(string ID)
        {
            myID = ID;
        }
        public string getMyID()
        {
            return myID;
        }


        public bool SignUpuser(string userid)
        {
            if (dBQuery.Insert("USERLIST","(USERID)","('" + userid +"')"))
            {
                return dBQuery.Insert("LOGINOUT",
                "(USERID, LASTLOGIN, STATUS)",
                "('" + userid + "', to_char(sysdate,'yyyy.mm.dd hh24:mi'), 1 )");
            }
            else
            {
                return false;
            }

        }
        public bool LoginUser(string userid)
        {
            setMyID(userid);
            OleDbDataReader reader = dBQuery.Select("*", "USERLIST", "USERID= '" + userid + "'");
            if (reader.Read())
            {
                connection.Close();
                return dBQuery.Update("LOGINOUT",
                "STATUS = 1, " +
                "LASTLOGIN = to_char(sysdate,'yyyy.mm.dd hh24:mi')",
                "USERID='" + userid + "'");
            }
            else
            {
                connection.Close();
                return false;
            }

        }
        public void LogoutUser()
        {
            dBQuery.Update("LOGINOUT",
                "STATUS = 0, " +
                "LASTLOGOUT = to_char(sysdate,'yyyy.mm.dd hh24:mi')",
                "USERID='" + myID + "'");
            myID = null;
        }

        public bool AddRestaurant(string nameR,string category, string signatureMenu)
        {
            return dBQuery.Insert("RL",
                "(SEQR, NAMER, CATEGORY, COUNT, SIGNATURE)",
                "(SEQR.nextval, '" + nameR + "', '" + category + "', 0, '" + signatureMenu + "')");
            
            //string temp = "";
            //if (dBQuery.Insert("RL",
            //    "(SEQR, NAMER, CATEGORY, COUNT, SIGNATURE)",
            //    "(SEQR.nextval, '" + nameR + "', '" + category + "', 0, '" + signatureMenu + "')"))
            //{
            //    OleDbDataReader reader = dBQuery.Select("seqr", "RL", "namer='" + nameR + "'");
            //    while (reader.Read())
            //    {
            //        temp = reader["seqr"] as string;
            //        Console.WriteLine("==============================" + temp + "==============================");

            //    }
                
            //    return dBQuery.Insert("EDITR",
            //   "(SEQE, EDATE, ECONTENT, USERID, SEQR)",
            //   "(SEQE.nextval, to_char(sysdate,'yyyy.mm.dd'), '추가','" + myID + "', "+temp+ ")");
            //} else
            //    return false;
            
        }

        public bool RemoveRestaurant(string nameR, string category)
        {
            return dBQuery.Delete("RL","NAMER = '"+nameR+"' AND CATEGORY = '"+category+"'");
        }


        public DataSet ShowUser()
        {
            return dBQuery.SelectNowhere("USERID", "USERLIST");
        }


        public DataSet ShowSelRest()
        {
            return dBQuery.SelectRest("SELECT r.CATEGORY as \"카테고리\", r.NAMER as \"식당명\", r.COUNT as \"추천수\", r.SIGNATURE as \"메뉴 메인\", s.selecteddate as \"최근 추천일\", nvl(s.userid, '-') as \"추천인\" FROM RL R LEFT OUTER JOIN selectedR s ON s.seqr = r.seqr ORDER BY s.SELECTEDDATE DESC");
        }

        public DataSet ShowSelRest(DateTime from, DateTime to, CheckedItemCollection category, string myID)
        {

            TimeSpan interval = to - from;
            if (interval.Days >= 1)
            {
                if (category.Count > 0)
                {
                    string catelist = "s.seqr = r.seqr and (";
                    for (int i = 0; i < category.Count; i++)
                    {
                        catelist += " (r.category ='" + category[i] + "')";
                        if (i == category.Count - 1)
                        {
                            break;
                        }
                        catelist += " or ";
                    }
                    catelist += " ) and (s.selecteddate >= '" + from.ToString("yyyy.MM.dd") +
                        "' and s.selecteddate <= '" + to.ToString("yyyy.MM.dd") + "') ";
                    if (myID != "추천인 선택")
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            catelist + " and (s.userid = '" + myID + "') " +
                            "order by s.selecteddate desc");
                    }
                    else
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            catelist +
                            "order by s.selecteddate desc");
                    }
                }
                else
                {
                    if (myID != "추천인 선택")
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            "s.seqr = r.seqr and" +
                            "(s.selecteddate >= '" + from.ToString("yyyy.MM.dd") +
                            "' and s.selecteddate <= '" + to.ToString("yyyy.MM.dd") + "') and " +
                            "(s.userid = '" + myID + "') " +
                            "order by s.selecteddate desc");
                    }
                    else
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            "s.seqr = r.seqr and" +
                            "(s.selecteddate >= '" + from.ToString("yyyy.MM.dd") +
                            "' and s.selecteddate <= '" + to.ToString("yyyy.MM.dd") + "')" +
                            "order by s.selecteddate desc");
                    }
                }
            }
            else
            {
                if (category.Count > 0)
                {
                    string catelist = "s.seqr = r.seqr and (";
                    for (int i = 0; i < category.Count; i++)
                    {
                        catelist += " (r.category ='" + category[i] + "')";
                        if (i == category.Count - 1)
                        {
                            break;
                        }
                        catelist += " or ";
                    }
                    catelist += ") and (s.selecteddate = '" + to.ToString("yyyy.MM.dd") + "') ";
                    if (myID != "추천인 선택")
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            catelist + " and (s.userid = '" + myID + "') " +
                            "order by s.selecteddate desc");
                    }
                    else
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            catelist +
                            "order by s.selecteddate desc");
                    }
                }
                else
                {
                    if (myID != "추천인 선택")
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            "s.seqr = r.seqr and" +
                            "(s.selecteddate = '" + to.ToString("yyyy.MM.dd") + "') and " +
                            "(s.userid = '" + myID + "') " +
                            "order by s.selecteddate desc");
                    }
                    else
                    {
                        return dBQuery.SelectRest("s.SEQSR, r.CATEGORY as \"카테고리\",r.NAMER as \"식당명\",r.COUNT as \"추천수\",r.SIGNATURE as \"메뉴 메인\",s.USERID as \"추천인\",s.SELECTEDDATE as \"최근 추천일\"",
                            "selectedR s, RL r",
                            "s.seqr = r.seqr and" +
                            "(s.selecteddate = '" + to.ToString("yyyy.MM.dd") + "')" +
                            "order by s.selecteddate desc");
                    }
                }
            }
        }
        public DataSet RecommendRest(string query)
        {

            
            Console.WriteLine(query);
            connection.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

            adapter.Fill(ds);
            connection.Close();
            return ds;

        }
        public bool SelectedRest(string seqr)
        {
            if (dBQuery.Insert("SELECTEDR",
                "(SEQSR,USERID,SEQR,SELECTEDDATE)",
                "(SEQSR.nextval,'"+myID+"' , "+seqr+", to_char(sysdate,'yyyy.mm.dd'))"))
            {
                return dBQuery.Update("RL",
                    "count = count+1",
                    "seqr = " + seqr);

            }
            else
            {
                return false;
            }
        }
    }
}

