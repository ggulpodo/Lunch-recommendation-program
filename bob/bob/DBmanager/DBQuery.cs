using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace bob.manager
{
    class DBQuery
    {
        public OleDbConnection connection = null;
        public OleDbCommand command = null;
        string query = "";

        public DBQuery(OleDbConnection conn)
        {
            connection = conn;
        }
        public bool Insert(string table, string column, string values)
        {
            try
            {
                query = "insert into " + table + column +" values " + values;
                connection.Open();
                command = new OleDbCommand(query, connection);

                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : " + e.StackTrace);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public OleDbDataReader Select(String target, string table, string where)
        {
            OleDbDataReader reader = null;
            query = "select " + target +
                    " from " + table +
                    " where " + where;
            connection.Open();
            command = new OleDbCommand(query, connection);
            reader = command.ExecuteReader();
            Console.WriteLine(query);

            return reader;

        }

        public bool Update(string table, string set, string where)
        {
            try
            {
                query = "update " + table +
                        " set " + set +
                        " where " + where;
                connection.Open();
                command = new OleDbCommand(query, connection);
                Console.WriteLine(query);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace + "ERROR");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool Delete(string table, string where)
        {
            try
            {
                query = "delete from " + table +
                        " where " + where;
                connection.Open();
                command = new OleDbCommand(query, connection);
                Console.WriteLine(query);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        /*
            메소드 오버로딩
            1. 파라미터로 입력받은 쿼리를 DataSet에 담아 return 해준다.
         */
        public DataSet SelectRest(string query)
        {
            OleDbDataAdapter adapter = null;
            DataSet ds = new DataSet();

            connection.Open();
            
            adapter = new OleDbDataAdapter(query, connection);
            Console.WriteLine(query);
            adapter.Fill(ds);
            connection.Close();
            return ds;

        }

        public DataSet SelectRest(string target, string table, string where)
        {
            OleDbDataAdapter adapter = null;
            DataSet ds = new DataSet();

            connection.Open();
            query = "select " + target +
                " from " + table +
                " where " + where;
            adapter = new OleDbDataAdapter(query, connection);
            Console.WriteLine(query);
            adapter.Fill(ds);
            connection.Close();
            return ds;
            
        }

        public DataSet SelectNowhere(string target, string table)
        {
            OleDbDataAdapter adapter = null;
            DataSet ds = new DataSet();

            connection.Open();
            query = "select " + target +
                " from " + table;
            adapter = new OleDbDataAdapter(query, connection);

            adapter.Fill(ds);
            connection.Close();
            return ds;
        }

        
    }
}
