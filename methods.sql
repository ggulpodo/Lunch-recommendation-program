private void RestaurantList_Load(object sender, EventArgs e)
        {
            RestaurantInform.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RestaurantInform.DataSource= logic.ShowRest().Tables[0];
            RestaurantInform.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
		
		
public DataSet ShowRest()
        {
            return query.SelectRest("r.*,s.selecteddate", "restaurantlist r, selectedrestaurantlist s", "r.resid=s.resid(+)");
        }
public DataSet ShowSelRest()
        {
            return query.SelectRest("s.SELECTEDID, r.CATEGORY,r.NAME,r.COUNT,r.SIGNITUREMENU,s.ID,s.SELECTEDDATE",
                "selectedrestaurantlist s, restaurantlist r",
                "s.resid = r.resid order by s.selecteddate desc");
        }
		
		
public DataSet SelectRest(string target, string table, string where)
        {
            OleDbDataAdapter adapter = null;
            DataSet ds = new DataSet();

            conn.Open();
            que = "select " + target + 
                " from " + table +
                " where " + where;
            adapter = new OleDbDataAdapter(que, conn);

            adapter.Fill(ds);
            conn.Close();
            return ds;
        }